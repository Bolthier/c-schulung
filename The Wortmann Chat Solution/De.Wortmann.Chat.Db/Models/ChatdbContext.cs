using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace De.Wortmann.Chat.Db.Models;

public partial class ChatdbContext : DbContext
{
    public ChatdbContext()
    {
    }

    public ChatdbContext(DbContextOptions<ChatdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chat> Chats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\LABS\\The Wortmann Chat Solution\\Files\\chatdb.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chat>(entity =>
        {
            entity.ToTable("chat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Datecreate).HasColumnName("datecreate");
            entity.Property(e => e.Header).HasColumnName("header");
            entity.Property(e => e.Sender).HasColumnName("sender");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
