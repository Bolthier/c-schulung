using Hangman_Console.Business;
using System.Text.Json;

namespace Hangman_Forms
{
    public partial class Form1 : Form
    {
        public Hangman Spiel { get; set; } = new Hangman();
        public Overview Overview { get; set; } = new Overview();
        public Form1()
        {
            InitializeComponent();
        }

        private void TheView_Click(object sender, EventArgs e)
        {

        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spiel = new Hangman();
            ZeigeAn();
        }

        private void ZeigeAn()
        {
            lbTheView.Text = Spiel.TheView;
            lbFehler.Text = Spiel.ErrorCount.ToString();
            try
            {
                Image img = Image.FromFile($@"C:\LABS\Hangman-Console\Images\galgen-{Spiel.ErrorCount}.png");
                pbFehler.Image = img;
            }
            catch (Exception)
            {
            }

            Niederlagen.Text = "Niederlagen: " + Overview.Niederlagen;
            Siege.Text = "Siege: " + Overview.Siege;
            Spiele.Text = "Spiele: " + Overview.SpieleAnzahl;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                var bt = new Button()
                {
                    Text = c.ToString(),
                    Font = new Font("Arial", 18, FontStyle.Regular),
                    Width = 50,
                    Height = 50,
                };

                bt.Click += Bt_Click;

                pTastatur.Controls.Add(bt);
            }
            if (File.Exists("C:\LABS\Hangman - Console\lastgame.json"))
            {
                Spiel = JsonDe
            }
        }

        private void Bt_Click(object? sender, EventArgs e)
        {
            Button bt = sender as Button;
            Spiel.Input(bt.Text);
            if (Spiel.IsWon)
            {
                MessageBox.Show("Gewonnen!");
                Overview.Siege++;
                Spiel = new Hangman();
                Overview.SpieleAnzahl++;
            }
            else if (Spiel.IsDead)
            {
                MessageBox.Show("Verloren!");
                Overview.Niederlagen++;
                Spiel = new Hangman();
                Overview.SpieleAnzahl++;
            }
            else
            {
            }
            ZeigeAn();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(@"C:\LABS\Hangman-Console\lastgame.json", JsonSerializer.Serialize<Spiel>);
        }
    }
}
