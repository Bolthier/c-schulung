using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace WortmannNoteWebApi.Models
{
    public class WortmannNoteContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<NoteModel> Notes { get; set; }
        static bool isConf = true;
        public WortmannNoteContext()
        {
            if (!isConf)
            {
                isConf = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
                Users.Add(new UserModel { Id = Guid.NewGuid(), Name = "Toby", Password = "Terra" });
                Users.Add(new UserModel { Id = Guid.NewGuid(), Name = "Andi", Password = "Terra" });
                Users.Add(new UserModel { Id = Guid.NewGuid(), Name = "Mirko", Password = "Terra" });
                Users.Add(new UserModel { Id = Guid.NewGuid(), Name = "Willy", Password = "Terra" });
                SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\LABS\Database\notes.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserModel>()
            .HasMany(e => e.Notes)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired();
        }
    }
}
