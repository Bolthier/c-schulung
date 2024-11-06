using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilder2DB
{
    public class BildModel
    {
        [Key]
        public string VollerName { get; set; }
        public string Name { get; set; }
        public string Typ { get; set; }
        public DateTime Datum { get; set; }
        public int Groesse { get; set; }
        public byte[] Daten { get; set; }

    }
}
