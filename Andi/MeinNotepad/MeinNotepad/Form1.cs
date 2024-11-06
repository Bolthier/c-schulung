namespace MeinNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void endeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();  //beendet Forms-Anwendung
        }

        private void txTheText_TextChanged(object sender, EventArgs e)
        {
            lbZeichen.Text = $"Zeichen: {txTheText.Text.Length}";
            lbWoerter.Text = $"Wörter: {txTheText.Text.Split(' ', '\r').Length}";

        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txTheText.Text);
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txTheText.Text = File.ReadAllText(dlg.FileName);
            }
        }
    }
}
