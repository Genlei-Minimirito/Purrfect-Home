namespace Lagen
{
    partial class displayCat
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            catName = new Label();
            btnSell = new PictureBox();
            btnEquip = new PictureBox();
            btnEditNickname = new PictureBox();
            nickname = new TextBox();
            editApply = new PictureBox();
            starPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEquip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditNickname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editApply).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starPic).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(183, 270);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Purrfect_Home.Properties.Resources.BACK_ASSET;
            pictureBox2.Location = new Point(-1, -3);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // catName
            // 
            catName.BackColor = Color.Transparent;
            catName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            catName.ForeColor = Color.FromArgb(128, 64, 64);
            catName.Location = new Point(870, 324);
            catName.Name = "catName";
            catName.Size = new Size(281, 36);
            catName.TabIndex = 3;
            catName.Text = "label2";
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.Transparent;
            btnSell.Location = new Point(879, 697);
            btnSell.Margin = new Padding(3, 4, 3, 4);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(236, 54);
            btnSell.TabIndex = 5;
            btnSell.TabStop = false;
            btnSell.Click += btnSell_Click;
            // 
            // btnEquip
            // 
            btnEquip.BackColor = Color.Transparent;
            btnEquip.Location = new Point(1133, 690);
            btnEquip.Margin = new Padding(3, 4, 3, 4);
            btnEquip.Name = "btnEquip";
            btnEquip.Size = new Size(230, 61);
            btnEquip.TabIndex = 6;
            btnEquip.TabStop = false;
            btnEquip.Click += btnEquip_Click;
            // 
            // btnEditNickname
            // 
            btnEditNickname.BackColor = Color.Transparent;
            btnEditNickname.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditNickname.Image = Purrfect_Home.Properties.Resources.EDIT_ASSET;
            btnEditNickname.Location = new Point(1112, 247);
            btnEditNickname.Margin = new Padding(3, 4, 3, 4);
            btnEditNickname.Name = "btnEditNickname";
            btnEditNickname.Size = new Size(74, 66);
            btnEditNickname.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEditNickname.TabIndex = 7;
            btnEditNickname.TabStop = false;
            btnEditNickname.Click += btnEditNickname_Click;
            // 
            // nickname
            // 
            nickname.BackColor = Color.FromArgb(228, 217, 197);
            nickname.BorderStyle = BorderStyle.FixedSingle;
            nickname.Enabled = false;
            nickname.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nickname.ForeColor = Color.FromArgb(128, 64, 64);
            nickname.Location = new Point(765, 247);
            nickname.Margin = new Padding(3, 4, 3, 4);
            nickname.Multiline = true;
            nickname.Name = "nickname";
            nickname.ReadOnly = true;
            nickname.Size = new Size(341, 66);
            nickname.TabIndex = 8;
            // 
            // editApply
            // 
            editApply.BackColor = Color.Transparent;
            editApply.BackgroundImageLayout = ImageLayout.Stretch;
            editApply.Image = Purrfect_Home.Properties.Resources.CHECK_ASSET;
            editApply.Location = new Point(1112, 247);
            editApply.Margin = new Padding(3, 4, 3, 4);
            editApply.Name = "editApply";
            editApply.Size = new Size(74, 67);
            editApply.SizeMode = PictureBoxSizeMode.StretchImage;
            editApply.TabIndex = 9;
            editApply.TabStop = false;
            editApply.Visible = false;
            editApply.Click += editApply_Click;
            // 
            // starPic
            // 
            starPic.BackColor = Color.Transparent;
            starPic.BackgroundImageLayout = ImageLayout.None;
            starPic.Location = new Point(630, 447);
            starPic.Margin = new Padding(3, 4, 3, 4);
            starPic.Name = "starPic";
            starPic.Size = new Size(476, 39);
            starPic.SizeMode = PictureBoxSizeMode.StretchImage;
            starPic.TabIndex = 10;
            starPic.TabStop = false;
            // 
            // displayCat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Purrfect_Home.Properties.Resources.DISPLAY_CAT_UI;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1361, 750);
            Controls.Add(starPic);
            Controls.Add(nickname);
            Controls.Add(btnEditNickname);
            Controls.Add(btnEquip);
            Controls.Add(btnSell);
            Controls.Add(catName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(editApply);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "displayCat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "displayCat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSell).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEquip).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditNickname).EndInit();
            ((System.ComponentModel.ISupportInitialize)editApply).EndInit();
            ((System.ComponentModel.ISupportInitialize)starPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label catName;
        private PictureBox btnSell;
        private PictureBox btnEquip;
        private PictureBox btnEditNickname;
        private TextBox nickname;
        private PictureBox editApply;
        private PictureBox starPic;
    }
}