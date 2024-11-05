using De.Wortmann.Banken.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace De.Wortmann.Bank.Implementation
{
    public class DbBankHelper : BankHelper
    {
        private List<BankModel> bankModels;
        public string ConnectionString { get; set; } =
            "Data Source = 172.26.7.67;Initial Catalog=WORTMANN_DB;User=sa;Password=Terra$;TrustServerCertificate=True";

        public BankModel[] Result => throw new NotImplementedException();

        public BankModel[] AlleBanken
        {
            get
            {
                var result = new List<BankModel>();
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $"select * from BLZ_TABELLE";
                        using (var reader = command.ExecuteReader())
                        {
                            result.Add(new BankModel()
                            {
                                BLZ = reader["blz"] + "",
                                Name = reader["Nname"] + "",
                                Plz = reader["plz"] + "",
                                Ort = reader["ort"] + ""
                            });
                        }
                    }
                }
                return result.ToArray();
            }
        }
        public BankHelper StartSuche(string suche)
        {
            bankModels =
                AlleBanken
                .Where(bm => bm.Plz.StartsWith(suche.Substring(0, 4)))
                .ToList();
            return this;
        }
    }
}
