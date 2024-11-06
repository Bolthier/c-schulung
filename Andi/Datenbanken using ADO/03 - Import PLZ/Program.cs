using Microsoft.Data.SqlClient;

Console.WriteLine("Insert Into...");

using (var con =
        new SqlConnection("Data Source=172.26.7.67;Initial Catalog=WORTMANN_DB;User=sa;Password=Terra$;TrustServerCertificate=True"))
{
    con.Open();
    using (var cmd = con.CreateCommand())
    {
        cmd.CommandText = "insert into PLZ_TABELLE (id,plz,ort,landkreis,bundesland) values(@id,@plz,@ort,@lk,@bl)";
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@id" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@plz" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@ort" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@lk" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@bl" });

        var alle = File.ReadLines(@"t:\installs\plz.csv")
            .Select(x => new
            {
                Plz = x.Split(',')[3],
                Ort = x.Split(',')[2],
                Lk = x.Split(',')[4],
                Bl = x.Split(',')[5]
            });

        int i = 0;

        using (var trans= con.BeginTransaction())
        {
            cmd.Transaction = trans;
            try
            {
                foreach (var p in alle)
                {
                    cmd.Parameters["@id"].Value = i++;
                    cmd.Parameters["@plz"].Value = p.Plz;
                    cmd.Parameters["@ort"].Value = p.Ort;
                    cmd.Parameters["@lk"].Value = p.Lk;
                    cmd.Parameters["@bl"].Value = p.Bl;
                    cmd.ExecuteNonQuery();
                    Console.Write($"\b\b\b\b\b\b\b\b{i}");
                    
                }
                trans.Commit();
                Console.WriteLine("Feddisch...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("FEHLER: "+ex.Message);
                trans.Rollback();
            }
        }


    }
}
