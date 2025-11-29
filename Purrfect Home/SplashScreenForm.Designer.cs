namespace Purrfect_Home
{
    partial class SplashScreenForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            picSplash = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSplash).BeginInit();
            SuspendLayout();
            // 
            // picSplash
            // 
            picSplash.Image = Properties.Resources.SPLASH_SCREEN_ANIMATION;
            picSplash.Location = new Point(-1, -3);
            picSplash.Name = "picSplash";
            picSplash.Size = new Size(1362, 759);
            picSplash.TabIndex = 0;
            picSplash.TabStop = false;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 749);
            Controls.Add(picSplash);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreenForm";
            Text = "SplashScreenForm";
            Load += SplashScreenForm_Load;
            ((System.ComponentModel.ISupportInitialize)picSplash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox picSplash;
    }
}