using Microsoft.Data.SqlClient;
using System.Globalization;

Console.WriteLine("Datenbank Demolition Team!");
Console.WriteLine("Insert Into...");

using (var connection = 
    new SqlConnection("Data Source=172.26.7.67;Initial Catalog=WORTMANN_DB;User=sa;Password=Terra$;TrustServerCertificate=True"))
{
    connection.Open();
    using (var cmd = connection.CreateCommand())
    {
        cmd.CommandText = "INSERT INTO TEILNEHMER (id, vorname, nachname, geb_am, status) values(@id, @p1, @p2, @p3, @p4)";
        cmd.Parameters.AddWithValue("@p1", "Tobias");
        cmd.Parameters.AddWithValue("@p2", "Boldt");
        cmd.Parameters.AddWithValue("@p3", DateTime.Parse("28.10.1991", new CultureInfo("de")));
        cmd.Parameters.AddWithValue("@p4", "BÜSY...");
        cmd.Parameters.AddWithValue("@id", Guid.NewGuid());

        Console.WriteLine($"{cmd.ExecuteNonQuery()} Zeilen eingefügt...");
    }
}
