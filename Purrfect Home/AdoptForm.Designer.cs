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
            picMafiaBannerSelect = new PictureBox();
            picWinterBannerSelect = new PictureBox();
            picHome = new PictureBox();
            picWinterInfo = new PictureBox();
            picMafia = new PictureBox();
            picMafiaAdopt = new PictureBox();
            picMafiaInfo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picWinterBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWinterAdopt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMafiaBannerSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWinterBannerSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWinterInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMafia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMafiaAdopt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMafiaInfo).BeginInit();
            SuspendLayout();
            // 
            // picWinterBanner
            // 
            picWinterBanner.BackColor = Color.Transparent;
            picWinterBanner.BackgroundImageLayout = ImageLayout.Stretch;
            picWinterBanner.Image = (Image)resources.GetObject("picWinterBanner.Image");
            picWinterBanner.Location = new Point(0, 1);
            picWinterBanner.Name = "picWinterBanner";
            picWinterBanner.Size = new Size(1359, 750);
            picWinterBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picWinterBanner.TabIndex = 0;
            picWinterBanner.TabStop = false;
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
            // picMafiaBannerSelect
            // 
            picMafiaBannerSelect.BackColor = Color.Transparent;
            picMafiaBannerSelect.BackgroundImageLayout = ImageLayout.Stretch;
            picMafiaBannerSelect.Image = (Image)resources.GetObject("picMafiaBannerSelect.Image");
            picMafiaBannerSelect.Location = new Point(1249, 353);
            picMafiaBannerSelect.Name = "picMafiaBannerSelect";
            picMafiaBannerSelect.Size = new Size(112, 101);
            picMafiaBannerSelect.SizeMode = PictureBoxSizeMode.StretchImage;
            picMafiaBannerSelect.TabIndex = 2;
            picMafiaBannerSelect.TabStop = false;
            picMafiaBannerSelect.Click += picMafiaBannerSelect_Click;
            // 
            // picWinterBannerSelect
            // 
            picWinterBannerSelect.BackColor = Color.Transparent;
            picWinterBannerSelect.BackgroundImageLayout = ImageLayout.Stretch;
            picWinterBannerSelect.Image = Properties.Resources.LEFT_ARROW;
            picWinterBannerSelect.Location = new Point(0, 353);
            picWinterBannerSelect.Name = "picWinterBannerSelect";
            picWinterBannerSelect.Size = new Size(112, 101);
            picWinterBannerSelect.SizeMode = PictureBoxSizeMode.StretchImage;
            picWinterBannerSelect.TabIndex = 3;
            picWinterBannerSelect.TabStop = false;
            picWinterBannerSelect.Visible = false;
            picWinterBannerSelect.Click += picWinterBannerSelect_Click;
            // 
            // picHome
            // 
            picHome.BackgroundImageLayout = ImageLayout.Stretch;
            picHome.Image = Properties.Resources.HOME_ICON;
            picHome.Location = new Point(0, 1);
            picHome.Name = "picHome";
            picHome.Size = new Size(69, 58);
            picHome.SizeMode = PictureBoxSizeMode.StretchImage;
            picHome.TabIndex = 4;
            picHome.TabStop = false;
            picHome.Click += picHome_Click;
            // 
            // picWinterInfo
            // 
            picWinterInfo.Image = Properties.Resources.INFO_ICON_ASSET;
            picWinterInfo.Location = new Point(1297, 1);
            picWinterInfo.Name = "picWinterInfo";
            picWinterInfo.Size = new Size(64, 58);
            picWinterInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            picWinterInfo.TabIndex = 5;
            picWinterInfo.TabStop = false;
            picWinterInfo.Click += picWinterInfo_Click;
            // 
            // picMafia
            // 
            picMafia.BackColor = Color.Transparent;
            picMafia.BackgroundImageLayout = ImageLayout.Stretch;
            picMafia.Image = (Image)resources.GetObject("picMafia.Image");
            picMafia.Location = new Point(-1, 0);
            picMafia.Name = "picMafia";
            picMafia.Size = new Size(1359, 750);
            picMafia.SizeMode = PictureBoxSizeMode.StretchImage;
            picMafia.TabIndex = 6;
            picMafia.TabStop = false;
            picMafia.Visible = false;
            // 
            // picMafiaAdopt
            // 
            picMafiaAdopt.BackColor = Color.Transparent;
            picMafiaAdopt.BackgroundImageLayout = ImageLayout.Stretch;
            picMafiaAdopt.Cursor = Cursors.Cross;
            picMafiaAdopt.Location = new Point(429, 484);
            picMafiaAdopt.Name = "picMafiaAdopt";
            picMafiaAdopt.Size = new Size(499, 114);
            picMafiaAdopt.TabIndex = 7;
            picMafiaAdopt.TabStop = false;
            picMafiaAdopt.Visible = false;
            picMafiaAdopt.Click += picMafiaAdopt_Click;
            // 
            // picMafiaInfo
            // 
            picMafiaInfo.Image = Properties.Resources.INFO_ICON_ASSET;
            picMafiaInfo.Location = new Point(1292, 0);
            picMafiaInfo.Name = "picMafiaInfo";
            picMafiaInfo.Size = new Size(69, 58);
            picMafiaInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            picMafiaInfo.TabIndex = 8;
            picMafiaInfo.TabStop = false;
            picMafiaInfo.Visible = false;
            picMafiaInfo.Click += picMafiaInfo_Click;
            // 
            // AdoptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WINTER_BANNER_ANIMATION;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(picMafiaInfo);
            Controls.Add(picMafiaAdopt);
            Controls.Add(picWinterInfo);
            Controls.Add(picHome);
            Controls.Add(picWinterBannerSelect);
            Controls.Add(picMafiaBannerSelect);
            Controls.Add(picWinterAdopt);
            Controls.Add(picWinterBanner);
            Controls.Add(picMafia);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdoptForm";
            ((System.ComponentModel.ISupportInitialize)picWinterBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWinterAdopt).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMafiaBannerSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWinterBannerSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWinterInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMafia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMafiaAdopt).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMafiaInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picWinterBanner;
        private PictureBox picWinterAdopt;
        private PictureBox picMafiaBannerSelect;
        private PictureBox picWinterBannerSelect;
        private PictureBox picHome;
        private PictureBox picWinterInfo;
        private PictureBox picMafia;
        private PictureBox picMafiaAdopt;
        private PictureBox picMafiaInfo;
    }
}