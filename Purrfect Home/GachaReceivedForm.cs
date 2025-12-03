using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Purrfect_Home
{
    public partial class GachaReceivedForm : Form
    {
        private AdoptForm adoptForm;
        private GachaResult gacha;

        // Keep stream alive while the form is open to allow GIF animation
        private MemoryStream gifStream;

        public GachaReceivedForm(AdoptForm adopt, GachaResult result)
        {
            InitializeComponent();
            adoptForm = adopt;
            gacha = result;

            DisplayGacha();
        }

        private void DisplayGacha()
        {
            // Load GIF bytes into a MemoryStream and keep it in the field
            try
            {
                byte[] bytes = File.ReadAllBytes(gacha.FilePath);
                gifStream = new MemoryStream(bytes);
                Image img = Image.FromStream(gifStream);
                picCat.Image = img;
                picCat.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                picCat.Image = null;
                MessageBox.Show("Failed to load GIF: " + ex.Message);
            }
        }

        private void picOkai_Click(object sender, EventArgs e)
        {
            // Save result to inventory through AdoptForm (handles duplicate→coins)
            try
            {
                adoptForm.SaveGachaResultToInventory(gacha);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving gacha result: " + ex.Message);
            }

            // Return to adopt form
            adoptForm.StartPosition = FormStartPosition.Manual;
            adoptForm.Location = this.Location;
            adoptForm.Show();

            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Dispose image and stream when closing to free resources
            try
            {
                if (picCat.Image != null)
                {
                    picCat.Image.Dispose();
                    picCat.Image = null;
                }
                if (gifStream != null)
                {
                    gifStream.Dispose();
                    gifStream = null;
                }
            }
            catch { }

            base.OnFormClosed(e);
        }
    }
}
