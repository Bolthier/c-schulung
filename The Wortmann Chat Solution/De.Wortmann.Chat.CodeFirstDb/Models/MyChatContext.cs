using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Chat.CodeFirstDb.Models
{
    public class MyChatContext : DbContext
    {
        private static bool _isCreated = false;
        public DbSet<ChatModel> Chats { get; set; }
        public MyChatContext() {
        if (!_isCreated)
            {
            _isCreated = true;
            Database.EnsureDeleted();
            Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\LABS\The Wortmann Chat Solution\Files\chat2.db");

        }
    }
}
