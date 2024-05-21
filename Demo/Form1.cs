using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using System.IO;
using System.Reflection;
using Emgu.CV.CvEnum;
using HaarDetector;

namespace Demo
{
    public partial class Form1 : Form
    {
        Image<Bgr, Byte> image;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            PopulateCascades();
            PopulateMinNeighbors();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (!(result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes))
            {
                return;
            }

            try
            {
                image = new Image<Bgr, byte>(openFileDialog1.FileName);
                imgResult.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void PopulateCascades()
        {
            Type haarCascadeManagerType = typeof(CascadeManager);
            foreach (PropertyInfo pi in haarCascadeManagerType.GetProperties())
            {
                cbxHaarCascade.Items.Add(pi.Name);
            }

            cbxHaarCascade.SelectedIndex = 5;
        }


        private void PopulateMinNeighbors()
        {
            for (int i = 0; i <= 10; i++)
            {
                cbxMinNeighbors.Items.Add(i);
            }

            cbxMinNeighbors.SelectedIndex = cbxMinNeighbors.Items.Count - 1;
        }

        private void PopulateSizes(ComboBox cbx)
        {
            cbx.Items.Add("0");
            cbx.Items.Add("10");
            cbx.Items.Add("20");
            cbx.Items.Add("30");
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            btnDetect.Enabled = false;

            List<string> errors = new List<string>();

            if (image == null)
            {
                errors.Add("Please select Image");
            }

            string cascade = cbxHaarCascade.SelectedItem.ToString();                // chọn loại nhận diện
            double scaleFactor = 1.3; 
            int minNeighbors = Convert.ToInt32(cbxMinNeighbors.SelectedItem);
            //-----------------------------------------------------------------------------------------
            // loại bỏ những vùng hình ảnh ko có khả năng chứa đối tượng để giảm chi phí tính toán
            // và có thể loại bỏ một số  phát hiện sai 
            HAAR_DETECTION_TYPE detectionType = HAAR_DETECTION_TYPE.DO_CANNY_PRUNING ;
            //-----------------------------------------------------------------------------------------
            int min = 30;
            int max = 0;

            if (max != 0 && max < min)
            {
                errors.Add("Maximum Size cannot be less than Minium Size");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors.ToArray()), "ERROR!", MessageBoxButtons.OK);
                btnDetect.Enabled = true;
                return;
            }

            try
            {
                // gọi hàm nhận diện 
                Rectangle[] detected = Detector.Detect(image, cascade,
                    scaleFactor, minNeighbors,
                    detectionType,
                    min, max);

                using (Image<Bgr, Byte> imageCopy = image.Copy())
                {
                    foreach (Rectangle region in detected)
                    {
                        imageCopy.Draw(region, new Bgr(Color.Blue), 2);
                    }

                    imgResult.Image = imageCopy;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnDetect.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
