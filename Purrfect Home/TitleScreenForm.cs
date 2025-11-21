namespace Purrfect_Home
{
    public partial class TitleScreenForm : Form
    {
        public TitleScreenForm()
        {
            InitializeComponent();
        }

        private void TitleScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formSplash = new SplashScreenForm();
            formSplash.StartPosition = FormStartPosition.Manual;
            formSplash.Location = this.Location;
            formSplash.ShowDialog();
        }

        private void picCred_Click(object sender, EventArgs e)
        {

        }

        private void picExt_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
