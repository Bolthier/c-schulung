namespace MeinNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void endeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //beendet Forms Anwendung
        }

        private void LBZeichen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txTextInput_TextChanged(object sender, EventArgs e)
        {
            LBZeichen.Text = $"Zeichen: {txTextInput.Text.Length}";
            lbWörter.Text = $"Wörter: {txTextInput.Text.Split(' ', ',', '\r').Length}";
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txTextInput.Text);
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txTextInput.Text = File.ReadAllText(dlg.FileName);
            }

        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txTextInput.Text = "";
        }
    }
}
