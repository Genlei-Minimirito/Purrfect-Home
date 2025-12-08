namespace Purrfect_Home
{
    partial class WinterAnimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinterAnimationForm));
            picGachaAnimation = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGachaAnimation).BeginInit();
            SuspendLayout();
            // 
            // picGachaAnimation
            // 
            picGachaAnimation.Image = (Image)resources.GetObject("picGachaAnimation.Image");
            picGachaAnimation.Location = new Point(0, 0);
            picGachaAnimation.Name = "picGachaAnimation";
            picGachaAnimation.Size = new Size(1359, 750);
            picGachaAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            picGachaAnimation.TabIndex = 0;
            picGachaAnimation.TabStop = false;
            picGachaAnimation.Click += picGachaAnimation_Click;
            // 
            // WinterAnimationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 750);
            Controls.Add(picGachaAnimation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WinterAnimationForm";
            Text = "WinterAnimationForm";
            ((System.ComponentModel.ISupportInitialize)picGachaAnimation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGachaAnimation;
    }
}