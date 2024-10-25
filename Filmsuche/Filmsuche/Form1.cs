using System.Text.Json;

namespace Filmsuche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient() { BaseAddress = new Uri("https://omdbapi.com/") };
            var response = httpClient.GetAsync($"?apikey=477bca08&s={textBox1.Text}").Result;
            if (!response.IsSuccessStatusCode)
            {
                return;
            }
            var json = response.Content.ReadAsStringAsync().Result;
            FilmModel data = JsonSerializer.Deserialize<FilmModel>(json);
            if (data.Search == null)
            {
                return;
            }
            foreach (var f in data.Search)
            {
                var pb = new PictureBox() { Width = 300, Height = 300, SizeMode = PictureBoxSizeMode.Zoom};
                pb.ImageLocation = f.Poster;
                flowLayoutPanel1.Controls.Add(pb);
            }
        }
    }
}
