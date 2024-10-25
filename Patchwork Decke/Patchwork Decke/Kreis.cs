using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Patchwork_Decke
{
    public class Kreis : IFigur
    {
        public double Radius { get; set; }
        public Kreis(double radius)
        {
            Radius = radius;
        }
        public double GetFlächeninhalt()
        {
            return Math.Pow(Radius,2) * Math.PI;
        }
    }
}
