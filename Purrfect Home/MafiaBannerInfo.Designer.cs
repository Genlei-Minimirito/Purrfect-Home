namespace Purrfect_Home
{
    partial class MafiaBannerInfo
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
            picBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.Location = new Point(1103, 653);
            picBack.Name = "picBack";
            picBack.Size = new Size(217, 58);
            picBack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBack.TabIndex = 7;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // MafiaBannerInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MAFIA_BANNER_INFO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(picBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MafiaBannerInfo";
            Text = "MafiaBannerInfo";
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBack;
    }
}