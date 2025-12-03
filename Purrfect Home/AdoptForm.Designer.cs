namespace Purrfect_Home
{
    partial class AdoptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoptForm));
            picWinterBanner = new PictureBox();
            picWinterAdopt = new PictureBox();
            picRightWinter = new PictureBox();
            picLeftWInter = new PictureBox();
            picHome = new PictureBox();
            picWinterInfo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picWinterBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWinterAdopt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRightWinter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLeftWInter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWinterInfo).BeginInit();
            SuspendLayout();
            // 
            // picWinterBanner
            // 
            picWinterBanner.BackColor = Color.Transparent;
            picWinterBanner.BackgroundImageLayout = ImageLayout.Stretch;
            picWinterBanner.Image = (Image)resources.GetObject("picWinterBanner.Image");
            picWinterBanner.Location = new Point(0, 1);
            picWinterBanner.Name = "picWinterBanner";
            picWinterBanner.Size = new Size(1361, 750);
            picWinterBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picWinterBanner.TabIndex = 0;
            picWinterBanner.TabStop = false;
            picWinterBanner.Click += picWinterBanner_Click;
            // 
            // picWinterAdopt
            // 
            picWinterAdopt.BackColor = Color.Transparent;
            picWinterAdopt.BackgroundImageLayout = ImageLayout.Stretch;
            picWinterAdopt.Cursor = Cursors.Cross;
            picWinterAdopt.Location = new Point(439, 496);
            picWinterAdopt.Name = "picWinterAdopt";
            picWinterAdopt.Size = new Size(489, 120);
            picWinterAdopt.TabIndex = 1;
            picWinterAdopt.TabStop = false;
            picWinterAdopt.Click += picWinterAdopt_Click;
            // 
            // picRightWinter
            // 
            picRightWinter.BackColor = Color.Transparent;
            picRightWinter.BackgroundImageLayout = ImageLayout.Stretch;
            picRightWinter.Image = (Image)resources.GetObject("picRightWinter.Image");
            picRightWinter.Location = new Point(1249, 353);
            picRightWinter.Name = "picRightWinter";
            picRightWinter.Size = new Size(112, 101);
            picRightWinter.SizeMode = PictureBoxSizeMode.StretchImage;
            picRightWinter.TabIndex = 2;
            picRightWinter.TabStop = false;
            // 
            // picLeftWInter
            // 
            picLeftWInter.BackColor = Color.Transparent;
            picLeftWInter.BackgroundImageLayout = ImageLayout.Stretch;
            picLeftWInter.Image = Properties.Resources.LEFT_ARROW;
            picLeftWInter.Location = new Point(0, 353);
            picLeftWInter.Name = "picLeftWInter";
            picLeftWInter.Size = new Size(112, 101);
            picLeftWInter.SizeMode = PictureBoxSizeMode.StretchImage;
            picLeftWInter.TabIndex = 3;
            picLeftWInter.TabStop = false;
            // 
            // picHome
            // 
            picHome.Location = new Point(0, 1);
            picHome.Name = "picHome";
            picHome.Size = new Size(69, 58);
            picHome.TabIndex = 4;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picWinterInfo
            // 
            picWinterInfo.Location = new Point(1292, 1);
            picWinterInfo.Name = "picWinterInfo";
            picWinterInfo.Size = new Size(69, 58);
            picWinterInfo.TabIndex = 5;
            picWinterInfo.TabStop = false;
            // 
            // AdoptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(picWinterInfo);
            Controls.Add(picHome);
            Controls.Add(picLeftWInter);
            Controls.Add(picRightWinter);
            Controls.Add(picWinterAdopt);
            Controls.Add(picWinterBanner);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdoptForm";
            ((System.ComponentModel.ISupportInitialize)picWinterBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWinterAdopt).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRightWinter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLeftWInter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWinterInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picWinterBanner;
        private PictureBox picWinterAdopt;
        private PictureBox picRightWinter;
        private PictureBox picLeftWInter;
        private PictureBox picHome;
        private PictureBox picWinterInfo;
    }
}