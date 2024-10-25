using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLZ_Suche_3000
{
    public class Stadt
    {
        public int Osm_id { get; set; }
        public int Ags { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string Landkreis { get; set; }
        public string Bundesland { get; set; }
        Action Suche {  get; set; }

    }
}
