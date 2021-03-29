using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Models;

namespace EFCore
{
    public class MyContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<ReaderLibrary> ReaderLibraries { get; set; }


        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public MyContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Category>().ToTable("Categories");

            modelBuilder.Entity<Author>().HasOne(x => x.Biography).WithOne(x => x.Author).HasForeignKey<AuthorBiography>(x => x.AuthorId);

            modelBuilder.Entity<Author>().HasMany(x => x.Books).WithOne(x => x.Author);

            modelBuilder.Entity<ReaderLibrary>().ToTable("ReaderLibraries");

            modelBuilder.Entity<ReaderLibrary>().HasKey(x => new { x.ReaderId, x.LibraryId });
            modelBuilder.Entity<ReaderLibrary>().HasOne(x => x.Reader).WithMany(x => x.ReaderLibraries).HasForeignKey(x => x.ReaderId);
            modelBuilder.Entity<ReaderLibrary>().HasOne(x => x.Library).WithMany(x => x.ReaderLibraries).HasForeignKey(x => x.LibraryId);
        }
    }
}
