using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PmqLesson12.Models;

public partial class PmqProductDbContext : DbContext
{
    public PmqProductDbContext()
    {
    }

    public PmqProductDbContext(DbContextOptions<PmqProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-N8I0ERNO\\SQLEXPRESS03;Database=PmqProductDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PmqId).HasName("PK__Product__175E7677BA5DADED");

            entity.ToTable("Product");

            entity.Property(e => e.PmqId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PmqCategoryId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PmqCreateDate).HasColumnType("datetime");
            entity.Property(e => e.PmqDescription).HasMaxLength(500);
            entity.Property(e => e.PmqImages).HasMaxLength(255);
            entity.Property(e => e.PmqName).HasMaxLength(100);
            entity.Property(e => e.PmqPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PmqSalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PmqStatus).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
