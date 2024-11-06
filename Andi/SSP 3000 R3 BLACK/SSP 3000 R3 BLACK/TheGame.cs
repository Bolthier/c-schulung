using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP_3000_R3_BLACK
{
    public class TheGame
    {
        public int PunkteSpieler { get; set; } = 0;
        public int PunkteRechner { get; set; } = 0;

        public bool IstEnde { //readonly
            get { 
                return PunkteSpieler == 3 || PunkteRechner == 3; 
            } 
        }

        public int WahlRechner()
        {
            return new Random().Next(1, 4);
        }

        public void ErgebnisErmitteln(int wahlRechner,int wahlSpieler)
        {
            if (wahlRechner == wahlSpieler ) ;
            else if (wahlRechner == 1 && wahlSpieler == 2) PunkteSpieler++;
            else if (wahlRechner == 1 && wahlSpieler == 3) PunkteRechner++;
            else if (wahlRechner == 2 && wahlSpieler == 1) PunkteRechner++;
            else if (wahlRechner == 2 && wahlSpieler == 3) PunkteSpieler++;
            else if (wahlRechner == 3 && wahlSpieler == 1) PunkteSpieler++;
            else if (wahlRechner == 3 && wahlSpieler == 2) PunkteRechner++;
        }

    }
}

