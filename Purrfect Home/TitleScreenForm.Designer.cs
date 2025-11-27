namespace Purrfect_Home
{
    partial class TitleScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictPlay = new PictureBox();
            picCred = new PictureBox();
            picExt = new PictureBox();
            picMode = new PictureBox();
            picModeLight = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCred).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picModeLight).BeginInit();
            SuspendLayout();
            // 
            // pictPlay
            // 
            pictPlay.BackColor = Color.Transparent;
            pictPlay.Location = new Point(515, 385);
            pictPlay.Name = "pictPlay";
            pictPlay.Size = new Size(303, 94);
            pictPlay.TabIndex = 0;
            pictPlay.TabStop = false;
            pictPlay.Click += picPlay_Click;
            // 
            // picCred
            // 
            picCred.BackColor = Color.Transparent;
            picCred.Location = new Point(440, 507);
            picCred.Name = "picCred";
            picCred.Size = new Size(442, 70);
            picCred.TabIndex = 1;
            picCred.TabStop = false;
            picCred.Click += picCred_Click;
            // 
            // picExt
            // 
            picExt.BackColor = Color.Transparent;
            picExt.Location = new Point(534, 604);
            picExt.Name = "picExt";
            picExt.Size = new Size(264, 76);
            picExt.TabIndex = 2;
            picExt.TabStop = false;
            picExt.Click += picExt_Click;
            // 
            // picMode
            // 
            picMode.BackColor = Color.Transparent;
            picMode.Location = new Point(12, 5);
            picMode.Name = "picMode";
            picMode.Size = new Size(66, 59);
            picMode.TabIndex = 3;
            picMode.TabStop = false;
            picMode.Click += picMode_Click;
            // 
            // picModeLight
            // 
            picModeLight.BackColor = Color.Transparent;
            picModeLight.Location = new Point(12, 5);
            picModeLight.Name = "picModeLight";
            picModeLight.Size = new Size(66, 59);
            picModeLight.TabIndex = 4;
            picModeLight.TabStop = false;
            picModeLight.Visible = false;
            picModeLight.Click += picModeLight_Click;
            // 
            // TitleScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LIGHT_MODE_TITLE_SCREEN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(picModeLight);
            Controls.Add(picMode);
            Controls.Add(picExt);
            Controls.Add(picCred);
            Controls.Add(pictPlay);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TitleScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += TitleScreenForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCred).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)picModeLight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictPlay;
        private PictureBox picCred;
        private PictureBox picExt;
        private PictureBox picMode;
        private PictureBox picModeLight;
    }
}
