namespace Lagen
{
    partial class signUp
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtconfirm = new TextBox();
            BtnloginHere = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnloginHere).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(539, 562);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 71);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 168);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(207, 143, 80);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold);
            txtusername.ForeColor = Color.FromArgb(128, 64, 64);
            txtusername.Location = new Point(408, 237);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(533, 49);
            txtusername.TabIndex = 7;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(197, 125, 79);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold);
            txtpassword.ForeColor = Color.FromArgb(128, 64, 64);
            txtpassword.Location = new Point(408, 336);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(533, 54);
            txtpassword.TabIndex = 8;
            // 
            // txtconfirm
            // 
            txtconfirm.BackColor = Color.FromArgb(207, 143, 80);
            txtconfirm.BorderStyle = BorderStyle.None;
            txtconfirm.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold);
            txtconfirm.ForeColor = Color.FromArgb(128, 64, 64);
            txtconfirm.Location = new Point(436, 457);
            txtconfirm.Margin = new Padding(3, 4, 3, 4);
            txtconfirm.Multiline = true;
            txtconfirm.Name = "txtconfirm";
            txtconfirm.PasswordChar = '*';
            txtconfirm.Size = new Size(480, 52);
            txtconfirm.TabIndex = 11;
            // 
            // BtnloginHere
            // 
            BtnloginHere.BackColor = Color.Transparent;
            BtnloginHere.Location = new Point(796, 697);
            BtnloginHere.Margin = new Padding(3, 4, 3, 4);
            BtnloginHere.Name = "BtnloginHere";
            BtnloginHere.Size = new Size(168, 30);
            BtnloginHere.TabIndex = 14;
            BtnloginHere.TabStop = false;
            BtnloginHere.Click += BtnloginHere_Click;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Purrfect_Home.Properties.Resources.SIGN_UP_UI;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1361, 750);
            Controls.Add(BtnloginHere);
            Controls.Add(pictureBox1);
            Controls.Add(txtconfirm);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "signUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnloginHere).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtconfirm;
        private PictureBox BtnloginHere;
    }
}