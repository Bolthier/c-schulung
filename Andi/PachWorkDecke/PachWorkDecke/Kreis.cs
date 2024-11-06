using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PachWorkDecke
{
    public class Kreis : IFigur
    {
        public double Radius { get; set; }
        public Kreis(double radius) {
            Radius = radius;
        }
        public double GetFlaecheninhalt()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
