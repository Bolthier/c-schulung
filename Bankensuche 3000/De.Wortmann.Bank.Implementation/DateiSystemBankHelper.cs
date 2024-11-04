using De.Wortmann.Banken.Interfaces;

namespace De.Wortmann.Bank.Implementation
{
    public class DateiSystemBankHelper : BankHelper
    {
        private List<BankModel> bankModels;
        public string ConnectionString { get; set; } = @"Z:\Installs\blz.txt";

        public BankModel[] Result => bankModels?.ToArray();

        public BankModel[] AlleBanken => File.ReadAllLines(ConnectionString)
                .Select(z => new BankModel()
                {
                    BLZ = z.Substring(0, 9),
                    Name = z.Substring(9, 57).Trim(),
                    Plz = z.Substring(67, 5),
                    Ort = z.Substring(72, 35).Trim(),
                    BIC = z.Substring(139, 18).Trim()
                })
                .ToArray();

        public BankHelper StartSuche(string suche)
        {
            bankModels = 
                AlleBanken
                .Where(bm=>bm.Plz.StartsWith(suche.Substring(0,4)))
                .ToList();
            return this;
        }
    }
}
