using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PachWorkDecke
{
    public class Dreieck : IFigur
    {
        public double Hoehe { get; set; }
        public double Breite { get; set; }
        public double GetFlaecheninhalt()
        {
            return (Hoehe*Breite)/2;
        }
    }
}
