using De.Andi.WIE.Business;
using System.Windows.Forms;

namespace Bildersucher_Form
{
    public partial class Form1 : Form
    {
        public BilderSammler BilderSammler { get; set; } = new BilderSammler();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in BilderSammler.WurzelVerzeichnisse)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 1;
            BilderSammler.IchScanneGeradeEinVerzeichnis += BilderSammler_IchScanneGeradeEinVerzeichnis;
        }

        private void BilderSammler_IchScanneGeradeEinVerzeichnis(string obj)
        {
            label2.Invoke(() => label2.Text=obj);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            BilderSammler.Verzeichnis = comboBox1.SelectedItem+"";
            await Task.Run(() => 
            {
                BilderSammler.Start();
            });
            label2.Text = "";
            listBox1.DataSource = BilderSammler.Bilders.OrderByDescending(x=>x.Length).ToList();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var img = Image.FromFile(listBox1.SelectedValue + "");
                pictureBox1.Image = img;

            }
            catch (Exception)
            {

            }        
        }
    }
}
