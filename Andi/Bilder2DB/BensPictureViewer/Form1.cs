using BensPictureViewer.Models;

namespace BensPictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ctx = new BilderContext())
            {
                foreach (var item in ctx.Bilders) {
                    PictureBox pictureBox = new PictureBox() { Width = 100, Height = 100, SizeMode = PictureBoxSizeMode.Zoom};
                    pictureBox.Image = Image.FromStream(new MemoryStream(item.Daten));
                    flpImages.Controls.Add(pictureBox);
                }
            }
        }
    }
}
