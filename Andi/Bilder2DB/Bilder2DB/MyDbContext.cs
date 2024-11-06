using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilder2DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<BildModel> Bilders { get; set; }
        public MyDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=t:/andi/bilder.db");
        }
    }
}
