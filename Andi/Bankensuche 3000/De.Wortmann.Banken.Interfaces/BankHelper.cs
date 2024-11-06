using System.Globalization;

namespace De.Wortmann.Banken.Interfaces
{
    public interface BankHelper
    {
        /// <summary>
        /// Verbindungzeichenfolge 
        /// </summary>
        public string ConnectionString { get; set; }
        public BankHelper StartSuche(string suche);
        public BankModel[] Result { get; }

        public BankModel[] AlleBanken { get; }


    }

    public class BankModel
    {
        public string Name { get; set; }
        public string BLZ { get; set; }
        public string BIC { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }

    }
}
