using Hangman_Console.Business;
using System.Text.Json;

namespace Hangman_Forms
{
    public partial class Form1 : Form
    {
        public Hangman Spiel { get; set; } = new Hangman();
        public Form1()
        {
            InitializeComponent();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spiel = new Hangman();
            ZeigeAn();
            foreach (Button bt in pTastatur.Controls)
            {
                bt.Enabled = true;
            }
        }

        private void ZeigeAn()
        {
            lbTheView.Text = Spiel.TheView;
            lbFehler.Text = Spiel.ErrorCount.ToString();
            try
            {
                Image img = Image.FromFile(@$"t:\images\galgen-{Spiel.ErrorCount}.png");
                pictureBox1.Image = img;
            }
            catch (Exception)
            {
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                var bt = new Button()
                {
                    Text = c.ToString(),
                    Font = new Font("Arial", 15, FontStyle.Bold),
                    Width = 45,
                    Height = 45
                };

                bt.Click += Bt_Click;

                pTastatur.Controls.Add(bt);
            }

            if (File.Exists(@"t:\andi\lasthm.json"))
            {
                Spiel = JsonSerializer.Deserialize<Hangman>(File.ReadAllText(@"t:\andi\lasthm.json"));
                ZeigeAn();
            }

        }

        private void Bt_Click(object? sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            Spiel.Input(bt.Text);
            if (Spiel.IsWon)
            {
                MessageBox.Show("GLÜCKWUNSCH");
                neuToolStripMenuItem_Click(null, null);
            }
            if (Spiel.IsDead)
            {
                MessageBox.Show("Verloren", Spiel.SecretWord);
                neuToolStripMenuItem_Click(null, null);
            }
            ZeigeAn();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(@"t:\andi\lasthm.json",JsonSerializer.Serialize(Spiel));
        }
    }
}
