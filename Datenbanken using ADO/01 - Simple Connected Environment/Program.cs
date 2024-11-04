// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

Console.WriteLine("Hello, Datenbank!");
Console.Write("Suche nach...");
var suche = Console.ReadLine();

using (var connection = new SqlConnection(
    "Data Source=172.26.7.67;Initial Catalog=NORTHWND;User=sa;Password=Terra$;TrustServerCertificate=True"))
{
    connection.Open();
    using (var command = connection.CreateCommand())
    {
        command.CommandText = $"SELECT * FROM products WHERE productname LIKE @suche ORDER BY productname";
        command.Parameters.AddWithValue("@suche",$"%{suche}%");
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine($"{reader["productname"]}");
            }
        }
    }
    
} // connection.Close();