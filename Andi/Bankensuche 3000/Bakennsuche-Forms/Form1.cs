using De.Wortmann.Bank.Implementations;

namespace Bakennsuche_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=new DbBankHelper().StartSuche(textBox1.Text).Result;
        }
    }
}
