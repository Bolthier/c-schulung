using Microsoft.Data.SqlClient;
using System.Globalization;

Console.WriteLine("Insert Into...");

using (var con=
        new SqlConnection("Data Source=172.26.7.67;Initial Catalog=WORTMANN_DB;User=sa;Password=Terra$;TrustServerCertificate=True"))
{
    con.Open();
	using (var cmd=con.CreateCommand())
	{
		cmd.CommandText = "insert into TEILNEHMER (id,vorname,nachname,geb_am,status) values(@id,@p1,@p2,@p3,@p4)";
        cmd.Parameters.AddWithValue("@p1", "Andi");
        cmd.Parameters.AddWithValue("@p2", "Bethke");
        cmd.Parameters.AddWithValue("@p3", DateTime.Parse("21.11.1970",new CultureInfo("de")));
        cmd.Parameters.AddWithValue("@p4", "BUSY...");
        cmd.Parameters.AddWithValue("@id", Guid.NewGuid());

        Console.WriteLine($"{cmd.ExecuteNonQuery()} Zeilen eingefügt...");
    }
}
