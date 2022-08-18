using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BookStore.API.Models;

namespace BookStore.API.Data
{
    public partial class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext()
        {
        }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=BookStoreDb;User Id=Tims;Password=LightningBolt1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => new { e.Author, e.Title }, "book_ak_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("author")
                    .IsFixedLength();

                entity.Property(e => e.PublicationDate)
                    .HasColumnType("date")
                    .HasColumnName("publication_date");

                entity.Property(e => e.Title)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("title")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
