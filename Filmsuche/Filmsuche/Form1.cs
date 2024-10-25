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
            flowLayoutPanel1.Controls.Clear();
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
                var pb = new BildMitTitelControl(f.Title, f.Poster) { Width = 300, Height = 300 };
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            foreach (BildMitTitelControl item in flowLayoutPanel1.Controls)
            {
                item.Width = trackBar1.Value;
                item.Height = trackBar1.Value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                e.Handled = true;
                button1_Click(sender, e);
            }
        }
    }
}
