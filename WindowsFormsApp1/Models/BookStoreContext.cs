using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MiniProject_BookStore.Models;

public partial class BookStoreContext : DbContext
{
    public BookStoreContext()
    {
    }

    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookImg> BookImgs { get; set; }

    public virtual DbSet<BookType> BookTypes { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database=BookStore; uid=sa;pwd=123456;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC277EB518FE");

            entity.HasIndex(e => e.BarCode, "IX_Unique_BarCode")
                .IsUnique()
                .HasFilter("([BarCode] IS NOT NULL)");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Author).HasMaxLength(256);
            entity.Property(e => e.BarCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BookTypeId).HasColumnName("BookTypeID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Price).HasColumnType("money");

            entity.HasOne(d => d.BookType).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Books__BookTypeI__267ABA7A");
        });

        modelBuilder.Entity<BookImg>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__BookImgs__3DE0C227205B6951");

            entity.Property(e => e.BookId)
                .ValueGeneratedNever()
                .HasColumnName("BookID");
            entity.Property(e => e.Img).HasColumnName("IMG");

            entity.HasOne(d => d.Book).WithOne(p => p.BookImg)
                .HasForeignKey<BookImg>(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BookImgs__BookID__2A4B4B5E");
        });

        modelBuilder.Entity<BookType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookType__3214EC27BC638205");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Invoices__3214EC278F6DCDCE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.BookId }).HasName("PK__InvoiceD__51CAE005B5399E01");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BookId).HasColumnName("BookID");

            entity.HasOne(d => d.Book).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK__InvoiceDe__BookI__300424B4");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK__InvoiceDetai__ID__2F10007B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
