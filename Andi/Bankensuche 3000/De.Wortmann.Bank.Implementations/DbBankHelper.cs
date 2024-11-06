using De.Wortmann.Banken.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Bank.Implementations
{
    public class DbBankHelper : BankHelper
    {
        public string ConnectionString { get; set; } = 
            "Data Source=172.26.7.67;Initial Catalog=WORTMANN_DB;User=sa;Password=Terra$;TrustServerCertificate=True";

        public BankModel[] Result { get; private set; }

        public BankModel[] AlleBanken
        {
            get
            {
                var result=new List<BankModel>();
                using (var con=new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (var cmd=con.CreateCommand())
                    {
                        cmd.CommandText = "select * from BLZ_TABELLE";
                        using (var rs=cmd.ExecuteReader())
                        {
                            while (rs.Read())
                            {
                                result.Add(new BankModel()
                                {
                                    BLZ = rs["blz"] + "",
                                    Name = rs["name"] + "",
                                    Plz = rs["plz"] + "",
                                    Ort = rs["ort"] + ""
                                });


                            }
                        }
                    }
                }
                return result.ToArray();
            }
        }

        public BankHelper StartSuche(string suche)
        {
            Result =
                   AlleBanken
                   .Where(bm => bm.Plz.StartsWith(suche.Substring(0, 4)))
                   .ToArray();
            return this;
        }
    }
}
