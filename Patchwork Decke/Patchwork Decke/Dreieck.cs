using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patchwork_Decke
{
    public class Dreieck : IFigur
    {
        public double Hoehe { get; set; }
        public double Breite { get; set; }

        public double GetFlächeninhalt()
        {
            return (Hoehe * Breite);
        }
    }
}
