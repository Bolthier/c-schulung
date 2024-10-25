using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmsuche
{
    public partial class BildMitTitelControl : UserControl
    {
        public BildMitTitelControl(string titel = "", string? imageurl=null)
        {
            InitializeComponent();
            label1.Text = titel;
            pictureBox1.ImageLocation = imageurl;
        }
    }
}
