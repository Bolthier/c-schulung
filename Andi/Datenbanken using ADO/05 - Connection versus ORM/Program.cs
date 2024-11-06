// See https://aka.ms/new-console-template for more information

using _05___Connection_versus_ORM.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Connection vs ORM");
var conStr = "Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True;Trust Server Certificate=True";

//UsingSimpleConnection();
UsingEF();

void UsingEF()
{
	using (var ctx = new NorthwndContext())
	{
		foreach (var c in ctx.Categories.Include("Products"))
		{
			Console.WriteLine($"{c.CategoryName}");
            foreach (var p in c.Products)
            {
                Console.WriteLine($"\t{p.ProductName}");
            }
        }
	}
}

void UsingSimpleConnection()
{
	using (var con=new SqlConnection(conStr))
	{
		con.Open();
		using (var cmd=con.CreateCommand())
		{
			cmd.CommandText = "Select * from Products";
			using (var rdr=cmd.ExecuteReader())
			{
                while (rdr.Read())
                {
					Console.WriteLine($"{rdr["productname"]}");
                }
            }
		}
	}
}