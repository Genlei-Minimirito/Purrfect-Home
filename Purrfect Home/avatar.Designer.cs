namespace Lagen
{
    partial class avatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(avatar));
            btnBack = new PictureBox();
            btnAvatar = new PictureBox();
            txtuser = new Label();
            txtid = new Label();
            txtcoins = new Label();
            txtBio = new TextBox();
            btnApplychanges = new PictureBox();
            editAvatar = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnApplychanges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Location = new Point(1031, 181);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 85);
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAvatar
            // 
            btnAvatar.BackColor = Color.Transparent;
            btnAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAvatar.BorderStyle = BorderStyle.FixedSingle;
            btnAvatar.Enabled = false;
            btnAvatar.Location = new Point(204, 235);
            btnAvatar.Margin = new Padding(3, 4, 3, 4);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.Size = new Size(252, 268);
            btnAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAvatar.TabIndex = 1;
            btnAvatar.TabStop = false;
            btnAvatar.Click += btnAvatar_Click;
            // 
            // txtuser
            // 
            txtuser.AutoSize = true;
            txtuser.BackColor = Color.Transparent;
            txtuser.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            txtuser.ForeColor = Color.FromArgb(255, 192, 128);
            txtuser.Location = new Point(641, 240);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(124, 42);
            txtuser.TabIndex = 2;
            txtuser.Text = "label1";
            // 
            // txtid
            // 
            txtid.AutoSize = true;
            txtid.BackColor = Color.Transparent;
            txtid.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            txtid.ForeColor = Color.FromArgb(255, 192, 128);
            txtid.Location = new Point(641, 317);
            txtid.Name = "txtid";
            txtid.Size = new Size(124, 42);
            txtid.TabIndex = 3;
            txtid.Text = "label1";
            // 
            // txtcoins
            // 
            txtcoins.AutoSize = true;
            txtcoins.BackColor = Color.Transparent;
            txtcoins.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            txtcoins.ForeColor = Color.FromArgb(255, 192, 128);
            txtcoins.Location = new Point(681, 397);
            txtcoins.Name = "txtcoins";
            txtcoins.Size = new Size(124, 42);
            txtcoins.TabIndex = 4;
            txtcoins.Text = "label1";
            // 
            // txtBio
            // 
            txtBio.BackColor = Color.FromArgb(230, 172, 88);
            txtBio.BorderStyle = BorderStyle.None;
            txtBio.Enabled = false;
            txtBio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBio.ForeColor = Color.Black;
            txtBio.Location = new Point(681, 467);
            txtBio.Margin = new Padding(3, 4, 3, 4);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.ReadOnly = true;
            txtBio.Size = new Size(256, 197);
            txtBio.TabIndex = 6;
            // 
            // btnApplychanges
            // 
            btnApplychanges.BackColor = Color.Transparent;
            btnApplychanges.BackgroundImageLayout = ImageLayout.Stretch;
            btnApplychanges.Image = Purrfect_Home.Properties.Resources.CHECK_ASSET;
            btnApplychanges.Location = new Point(1055, 595);
            btnApplychanges.Margin = new Padding(3, 4, 3, 4);
            btnApplychanges.Name = "btnApplychanges";
            btnApplychanges.Size = new Size(70, 79);
            btnApplychanges.SizeMode = PictureBoxSizeMode.StretchImage;
            btnApplychanges.TabIndex = 8;
            btnApplychanges.TabStop = false;
            btnApplychanges.Visible = false;
            btnApplychanges.Click += btnApplychanges_Click;
            // 
            // editAvatar
            // 
            editAvatar.BackColor = Color.Transparent;
            editAvatar.BackgroundImage = (Image)resources.GetObject("editAvatar.BackgroundImage");
            editAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            editAvatar.Location = new Point(1055, 595);
            editAvatar.Margin = new Padding(3, 4, 3, 4);
            editAvatar.Name = "editAvatar";
            editAvatar.Size = new Size(70, 79);
            editAvatar.TabIndex = 9;
            editAvatar.TabStop = false;
            editAvatar.Click += editAvatar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // avatar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 887);
            Controls.Add(pictureBox1);
            Controls.Add(editAvatar);
            Controls.Add(btnApplychanges);
            Controls.Add(txtBio);
            Controls.Add(txtcoins);
            Controls.Add(txtid);
            Controls.Add(txtuser);
            Controls.Add(btnAvatar);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "avatar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "avatar";
            Load += avatar_Load;
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnApplychanges).EndInit();
            ((System.ComponentModel.ISupportInitialize)editAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnBack;
        private PictureBox btnAvatar;
        private Label txtuser;
        private Label txtid;
        private Label txtcoins;
        private TextBox txtBio;
        private PictureBox btnApplychanges;
        private PictureBox editAvatar;
        private PictureBox pictureBox1;
    }
}