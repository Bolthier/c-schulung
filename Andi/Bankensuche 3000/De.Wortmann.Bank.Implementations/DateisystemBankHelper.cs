using De.Wortmann.Banken.Interfaces;

namespace De.Wortmann.Bank.Implementations
{
    public class DateisystemBankHelper : BankHelper
    {
        private List<BankModel> bankModels;
        public string ConnectionString { get; set; } = @"t:\installs\blz.txt";

        public BankModel[] Result => bankModels.ToArray();

        public BankModel[] AlleBanken => File.ReadAllLines(ConnectionString)
                    .Select(z => new BankModel()
                    {
                        BLZ = z.Substring(0, 9),
                        Name = z.Substring(9, 57).Trim(),
                        Plz = z.Substring(67, 5),
                        Ort = z.Substring(72, 35).Trim(),
                        BIC = z.Substring(130, 18)
                    })
            .ToArray();

        public BankHelper StartSuche(string suche)
        {
            bankModels=
                    AlleBanken
                    .Where(bm => bm.Plz.StartsWith(suche.Substring(0, 4)))
                    .ToList();
            return this;
        }
    }
}
