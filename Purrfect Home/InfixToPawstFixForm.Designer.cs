namespace InfixToPawstfixGame
{
    partial class InfixToPawstFixForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfixToPawstFixForm));
            lblCorrectAns = new Label();
            lblChoice1 = new Label();
            lblChoice3 = new Label();
            lblChoice2 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblPoints = new Label();
            lblGiven = new Label();
            picMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            SuspendLayout();
            // 
            // lblCorrectAns
            // 
            lblCorrectAns.BackColor = Color.Transparent;
            lblCorrectAns.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrectAns.Location = new Point(307, 684);
            lblCorrectAns.Name = "lblCorrectAns";
            lblCorrectAns.Size = new Size(739, 49);
            lblCorrectAns.TabIndex = 1;
            lblCorrectAns.Text = "AB+BBASKJDBH";
            // 
            // lblChoice1
            // 
            lblChoice1.BackColor = Color.Transparent;
            lblChoice1.Font = new Font("Showcard Gothic", 18F);
            lblChoice1.Location = new Point(33, 28);
            lblChoice1.Name = "lblChoice1";
            lblChoice1.Size = new Size(443, 97);
            lblChoice1.TabIndex = 7;
            lblChoice1.Text = "INFIX";
            lblChoice1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChoice3
            // 
            lblChoice3.BackColor = Color.Transparent;
            lblChoice3.Font = new Font("Showcard Gothic", 18F);
            lblChoice3.Location = new Point(897, 28);
            lblChoice3.Name = "lblChoice3";
            lblChoice3.Size = new Size(412, 97);
            lblChoice3.TabIndex = 8;
            lblChoice3.Text = "INFIX";
            lblChoice3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChoice2
            // 
            lblChoice2.BackColor = Color.Transparent;
            lblChoice2.Font = new Font("Showcard Gothic", 18F);
            lblChoice2.Location = new Point(435, 143);
            lblChoice2.Name = "lblChoice2";
            lblChoice2.Size = new Size(489, 97);
            lblChoice2.TabIndex = 9;
            lblChoice2.Text = "INFIX";
            lblChoice2.TextAlign = ContentAlignment.MiddleLeft;
            
            // 
            // lblPoints
            // 
            lblPoints.BackColor = Color.Transparent;
            lblPoints.Font = new Font("Showcard Gothic", 18F);
            lblPoints.ForeColor = SystemColors.ButtonHighlight;
            lblPoints.Location = new Point(146, 711);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(63, 35);
            lblPoints.TabIndex = 10;
            lblPoints.Text = "5";
            // 
            // lblGiven
            // 
            lblGiven.BackColor = Color.Transparent;
            lblGiven.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiven.Location = new Point(307, 615);
            lblGiven.Name = "lblGiven";
            lblGiven.Size = new Size(739, 49);
            lblGiven.TabIndex = 11;
            lblGiven.Text = "AB+BBASKJDBH";
            // 
            // picMenu
            // 
            picMenu.BackColor = Color.Transparent;
            picMenu.Location = new Point(1266, 671);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(73, 62);
            picMenu.TabIndex = 12;
            picMenu.TabStop = false;
            picMenu.Click += picMenu_Click;
            // 
            // InfixToPawstFixForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 750);
            Controls.Add(picMenu);
            Controls.Add(lblGiven);
            Controls.Add(lblPoints);
            Controls.Add(lblChoice2);
            Controls.Add(lblChoice3);
            Controls.Add(lblChoice1);
            Controls.Add(lblCorrectAns);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfixToPawstFixForm";
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCorrectAns;
        private Label lblChoice1;
        private Label lblChoice3;
        private Label lblChoice2;
        private System.Windows.Forms.Timer timer;
        private Label lblPoints;
        private Label lblGiven;
        private PictureBox picMenu;
    }
}
