using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallsEntscheidung
{
    public class FreieOptionen
    {
        public string Titel { get; set; }
        public int AnzahlOptionen { get; set; }
        public string[] Optionens { get; set; }
        public string Entscheidung()
        {
            return Optionens[new Random().Next(Optionens.Length)];
        }
    }
}
