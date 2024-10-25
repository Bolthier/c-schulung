using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patchwork_Decke
{
    public class Quadrat: IFigur
    {
        public double Kantenlaenge {  get; set; }
        public Quadrat(double kantenlaenge)
        {
            Kantenlaenge = kantenlaenge;
        }

        public double GetFlächeninhalt()
        {
            return Kantenlaenge * Kantenlaenge;
        }
    }
}
