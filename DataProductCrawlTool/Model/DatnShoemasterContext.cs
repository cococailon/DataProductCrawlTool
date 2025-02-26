using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataProductCrawlTool.Model;

public partial class DatnShoemasterContext : DbContext
{
    public DatnShoemasterContext()
    {
    }

    public DatnShoemasterContext(DbContextOptions<DatnShoemasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartDetail> CartDetails { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategoriesRelation> ProductCategoriesRelations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-RMH8P4C;Initial Catalog=DATN_SHOEMASTER;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BillDetail>(entity =>
        {
            entity.HasIndex(e => e.BillId, "IX_BillDetails_BillId");

            entity.HasIndex(e => e.ProductId, "IX_BillDetails_ProductId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Bill).WithMany(p => p.BillDetails).HasForeignKey(d => d.BillId);

            entity.HasOne(d => d.Product).WithMany(p => p.BillDetails).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CartDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TtlhrelateIdsJson).HasColumnName("TTLHRelateIdsJson");
            entity.Property(e => e.Ttthidmain).HasColumnName("TTTHIDMain");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductCategoriesRelation>(entity =>
        {
            entity.HasIndex(e => e.CategoriesId, "IX_ProductCategoriesRelations_CategoriesId");

            entity.HasIndex(e => e.IdProduct, "IX_ProductCategoriesRelations_IdProduct");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Categories).WithMany(p => p.ProductCategoriesRelations).HasForeignKey(d => d.CategoriesId);

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.ProductCategoriesRelations).HasForeignKey(d => d.IdProduct);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VoucherDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
