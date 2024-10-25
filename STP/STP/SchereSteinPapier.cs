using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP
{
    public class SchereSteinPapier
    {
        public int PointsHuman { get; set; }
        public int PointsRobot { get; set; }
        public bool IstEnde
        {
            get
            {
                return PointsHuman == 3 || PointsRobot == 3;
            }
        }
        public int WahlRechner()
        {
            return new Random().Next(1, 4);
        }
        public void ErgebnisErmitteln(int wahlRechner, int wahlSpieler)
        {
            if (wahlRechner == wahlSpieler) ;
            else if (wahlRechner == 2 && wahlSpieler == 3) PointsHuman++;
            else if (wahlRechner == 3 && wahlSpieler == 1) PointsHuman++;
            else if (wahlRechner == 1 && wahlSpieler == 2) PointsHuman++;
            else if (wahlRechner == 3 && wahlSpieler == 2) PointsRobot++;
            else if (wahlRechner == 2 && wahlSpieler == 1) PointsRobot++;
            else if (wahlRechner == 1 && wahlSpieler == 3) PointsRobot++;
        }

    }
}