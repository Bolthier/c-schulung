using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilder_To_Db
{
    public class MyImagesContext : DbContext
    {
        private static bool _isCreated = false;
        public DbSet<BildModel> Bilds { get; set; }
        public MyImagesContext()
        {
            if (!_isCreated)
            {
                _isCreated = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\LABS\Files\images.db");
        }
    }
}
