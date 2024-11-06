using Microsoft.Data.SqlClient;

Console.WriteLine("Insert Into...");

using (var con =
        new SqlConnection("Data Source=172.26.7.67;Initial Catalog=WORTMANN_DB;User=sa;Password=Terra$;TrustServerCertificate=True"))
{
    con.Open();
    using (var cmd = con.CreateCommand())
    {
        cmd.CommandText = "insert into BLZ_TABELLE (id,blz,name,plz,ort) values(@id,@blz,@name,@plz,@ort)";
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@id" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@blz" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@name" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@plz" });
        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@ort" });

        var alle = File.ReadLines(@"t:\installs\blz.txt")
            .Select(z => new
            {
                Blz = z.Substring(0, 9),
                Name = z.Substring(9, 57).Trim(),
                Plz = z.Substring(67, 5),
                Ort = z.Substring(72, 35).Trim()
            });

        int i = 0;

        using (var trans = con.BeginTransaction())
        {
            cmd.Transaction = trans;
            try
            {
                foreach (var p in alle)
                {
                    cmd.Parameters["@id"].Value = Guid.NewGuid();
                    cmd.Parameters["@blz"].Value = p.Blz;
                    cmd.Parameters["@name"].Value = p.Name;
                    cmd.Parameters["@plz"].Value = p.Plz;
                    cmd.Parameters["@ort"].Value = p.Ort;
                    cmd.ExecuteNonQuery();
                    Console.Write($"\b\b\b\b\b\b\b\b{i}");

                }
                trans.Commit();
                Console.WriteLine("Feddisch...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("FEHLER: " + ex.Message);
                trans.Rollback();
            }
        }


    }
}
