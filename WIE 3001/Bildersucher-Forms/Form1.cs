using De.Tobias.WIE.Business;

namespace Bildersucher_Forms
{
    public partial class Form1 : Form
    {
        public BilderSammler BilderSammler { get; set; } = new BilderSammler();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in BilderSammler.WurzelVerzeichnis)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.Text = BilderSammler.WurzelVerzeichnis[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            BilderSammler.Verzeichnis = comboBox1.Text;
            BilderSammler.Start();
            listBox1.DataSource = BilderSammler.Bilders.OrderByDescending(x => x.Length).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedValue != null)
                {
                    var img = Image.FromFile(listBox1.SelectedValue + "");
                    pictureBox1.Image = img;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
