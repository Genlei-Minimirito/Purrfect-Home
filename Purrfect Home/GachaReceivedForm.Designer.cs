namespace Purrfect_Home
{
    partial class GachaReceivedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GachaReceivedForm));
            picOkai = new PictureBox();
            picCat = new PictureBox();
            lblStars = new Label();
            ((System.ComponentModel.ISupportInitialize)picOkai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCat).BeginInit();
            SuspendLayout();
            // 
            // picOkai
            // 
            picOkai.BackColor = Color.Transparent;
            picOkai.Location = new Point(451, 533);
            picOkai.Name = "picOkai";
            picOkai.Size = new Size(433, 110);
            picOkai.TabIndex = 0;
            picOkai.TabStop = false;
            picOkai.Click += picOkai_Click;
            // 
            // picCat
            // 
            picCat.BackColor = Color.Transparent;
            picCat.Location = new Point(551, 329);
            picCat.Name = "picCat";
            picCat.Size = new Size(237, 198);
            picCat.SizeMode = PictureBoxSizeMode.StretchImage;
            picCat.TabIndex = 1;
            picCat.TabStop = false;
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Location = new Point(1014, 340);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(0, 20);
            lblStars.TabIndex = 2;
            // 
            // GachaReceivedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(lblStars);
            Controls.Add(picCat);
            Controls.Add(picOkai);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GachaReceivedForm";
            Text = "GachaReceivedForm";
            ((System.ComponentModel.ISupportInitialize)picOkai).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOkai;
        private PictureBox picCat;
        private Label lblStars;
    }
}