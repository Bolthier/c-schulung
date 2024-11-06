using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PachWorkDecke
{
    public class Quadrad : IFigur
    {
        public double Kantenlaenge { get; set; }

        public Quadrad(double kantenlaenge)
        {
            Kantenlaenge = kantenlaenge;
        }

        public double GetFlaecheninhalt()
        {
            return Math.Pow(Kantenlaenge,2);
        }
    }
}
