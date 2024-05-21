namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxMinNeighbors = new System.Windows.Forms.ComboBox();
            this.lblMinNeighbors = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxHaarCascade = new System.Windows.Forms.ComboBox();
            this.lblHaarCascade = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgResult = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png|All Images|*.jpg;*.jpeg;*.png";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(583, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 544);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnOpenFile);
            this.panel8.Controls.Add(this.btnDetect);
            this.panel8.Location = new System.Drawing.Point(6, 426);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(188, 50);
            this.panel8.TabIndex = 8;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(99, 10);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(70, 30);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(13, 10);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(70, 30);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxMinNeighbors);
            this.panel4.Controls.Add(this.lblMinNeighbors);
            this.panel4.Location = new System.Drawing.Point(3, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 50);
            this.panel4.TabIndex = 4;
            // 
            // cbxMinNeighbors
            // 
            this.cbxMinNeighbors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinNeighbors.FormattingEnabled = true;
            this.cbxMinNeighbors.Location = new System.Drawing.Point(3, 23);
            this.cbxMinNeighbors.Name = "cbxMinNeighbors";
            this.cbxMinNeighbors.Size = new System.Drawing.Size(182, 21);
            this.cbxMinNeighbors.TabIndex = 3;
            // 
            // lblMinNeighbors
            // 
            this.lblMinNeighbors.AutoSize = true;
            this.lblMinNeighbors.Location = new System.Drawing.Point(3, 7);
            this.lblMinNeighbors.Name = "lblMinNeighbors";
            this.lblMinNeighbors.Size = new System.Drawing.Size(99, 13);
            this.lblMinNeighbors.TabIndex = 2;
            this.lblMinNeighbors.Text = "Minimum Neighbors";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxHaarCascade);
            this.panel2.Controls.Add(this.lblHaarCascade);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 50);
            this.panel2.TabIndex = 2;
            // 
            // cbxHaarCascade
            // 
            this.cbxHaarCascade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHaarCascade.FormattingEnabled = true;
            this.cbxHaarCascade.Location = new System.Drawing.Point(3, 23);
            this.cbxHaarCascade.Name = "cbxHaarCascade";
            this.cbxHaarCascade.Size = new System.Drawing.Size(182, 21);
            this.cbxHaarCascade.TabIndex = 1;
            // 
            // lblHaarCascade
            // 
            this.lblHaarCascade.AutoSize = true;
            this.lblHaarCascade.Location = new System.Drawing.Point(3, 7);
            this.lblHaarCascade.Name = "lblHaarCascade";
            this.lblHaarCascade.Size = new System.Drawing.Size(75, 13);
            this.lblHaarCascade.TabIndex = 0;
            this.lblHaarCascade.Text = "Haar Cascade";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 544);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.imgResult);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 7);
            this.panel1.TabIndex = 0;
            // 
            // imgResult
            // 
            this.imgResult.Location = new System.Drawing.Point(-6, -19);
            this.imgResult.Name = "imgResult";
            this.imgResult.Size = new System.Drawing.Size(23, 23);
            this.imgResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgResult.TabIndex = 2;
            this.imgResult.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox imgResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxHaarCascade;
        private System.Windows.Forms.Label lblHaarCascade;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxMinNeighbors;
        private System.Windows.Forms.Label lblMinNeighbors;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

