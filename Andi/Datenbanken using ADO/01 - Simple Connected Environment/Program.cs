using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

Console.Write("Suche nach: ");
var suche=Console.ReadLine();

using (var connection = new SqlConnection(
    "Data Source=172.26.7.67;Initial Catalog=NORTHWND;User=sa;Password=Terra$;TrustServerCertificate=True"))
{
    connection.Open();
    using (var command = connection.CreateCommand())
    {
        command.CommandText = $"select * from products where productname like @suche";
        command.Parameters.AddWithValue("@suche", $"%{suche}%");
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine($"{reader["productname"]}");
            }
        }//ende vom reader             reader.Close();
    }

}  //ende der connection     connection.Close();


