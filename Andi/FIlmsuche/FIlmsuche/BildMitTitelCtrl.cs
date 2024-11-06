using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIlmsuche
{
    public partial class BildMitTitelCtrl : UserControl
    {
        public BildMitTitelCtrl(string titel="", string imageurl=null)
        {
            InitializeComponent();
            label1.Text = titel;
            pictureBox1.ImageLocation=imageurl;
        }
    }
}
