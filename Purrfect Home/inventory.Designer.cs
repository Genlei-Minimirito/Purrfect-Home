namespace Lagen
{
    partial class inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            picBack = new PictureBox();
            invent1 = new PictureBox();
            invent2 = new PictureBox();
            invent3 = new PictureBox();
            invent4 = new PictureBox();
            invent5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invent3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invent4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invent5).BeginInit();
            SuspendLayout();
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.Location = new Point(14, 16);
            picBack.Margin = new Padding(3, 4, 3, 4);
            picBack.Name = "picBack";
            picBack.Size = new Size(79, 68);
            picBack.TabIndex = 0;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // invent1
            // 
            invent1.BackColor = Color.Transparent;
            invent1.Location = new Point(811, 556);
            invent1.Margin = new Padding(3, 4, 3, 4);
            invent1.Name = "invent1";
            invent1.Size = new Size(181, 145);
            invent1.SizeMode = PictureBoxSizeMode.StretchImage;
            invent1.TabIndex = 1;
            invent1.TabStop = false;
            invent1.Click += invent1_Click;
            // 
            // invent2
            // 
            invent2.BackColor = Color.Transparent;
            invent2.Location = new Point(60, 310);
            invent2.Margin = new Padding(3, 4, 3, 4);
            invent2.Name = "invent2";
            invent2.Size = new Size(169, 142);
            invent2.SizeMode = PictureBoxSizeMode.StretchImage;
            invent2.TabIndex = 2;
            invent2.TabStop = false;
            // 
            // invent3
            // 
            invent3.BackColor = Color.Transparent;
            invent3.Location = new Point(296, 551);
            invent3.Margin = new Padding(3, 4, 3, 4);
            invent3.Name = "invent3";
            invent3.Size = new Size(182, 150);
            invent3.SizeMode = PictureBoxSizeMode.StretchImage;
            invent3.TabIndex = 3;
            invent3.TabStop = false;
            // 
            // invent4
            // 
            invent4.BackColor = Color.Transparent;
            invent4.Location = new Point(617, 408);
            invent4.Margin = new Padding(3, 4, 3, 4);
            invent4.Name = "invent4";
            invent4.Size = new Size(176, 161);
            invent4.SizeMode = PictureBoxSizeMode.StretchImage;
            invent4.TabIndex = 4;
            invent4.TabStop = false;
            
            // 
            // invent5
            // 
            invent5.BackColor = Color.Transparent;
            invent5.Location = new Point(1149, 521);
            invent5.Margin = new Padding(3, 4, 3, 4);
            invent5.Name = "invent5";
            invent5.Size = new Size(175, 170);
            invent5.SizeMode = PictureBoxSizeMode.StretchImage;
            invent5.TabIndex = 5;
            invent5.TabStop = false;
            // 
            // inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1361, 750);
            Controls.Add(invent5);
            Controls.Add(invent4);
            Controls.Add(invent3);
            Controls.Add(invent2);
            Controls.Add(invent1);
            Controls.Add(picBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inventory";
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)invent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)invent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)invent3).EndInit();
            ((System.ComponentModel.ISupportInitialize)invent4).EndInit();
            ((System.ComponentModel.ISupportInitialize)invent5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBack;
        private PictureBox invent1;
        private PictureBox invent2;
        private PictureBox invent3;
        private PictureBox invent4;
        private PictureBox invent5;
    }
}