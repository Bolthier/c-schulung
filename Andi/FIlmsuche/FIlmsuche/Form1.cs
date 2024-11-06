using System.Text.Json;
using System.Windows.Forms;

namespace FIlmsuche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var httpClient = new HttpClient() { BaseAddress = new Uri("https://omdbapi.com/") };
            var reponse =await httpClient.GetAsync($"?apikey=477bca08&s={textBox1.Text}");
            if (!reponse.IsSuccessStatusCode)
            {
                return;
            }
            var json = await reponse.Content.ReadAsStringAsync();
            FilmModel data = JsonSerializer.Deserialize<FilmModel>(json);
            if(data==null || data.Search==null) return;
            foreach (var f in data.Search)
            {
                var pb = new BildMitTitelCtrl(f.Title, f.Poster) { Width = 200, Height = 200 };
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            foreach (BildMitTitelCtrl item in flowLayoutPanel1.Controls)
            {
                item.Width = trackBar1.Value;
                item.Height = trackBar1.Value;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                button1_Click(sender, e);
            }
        }
    }
}
