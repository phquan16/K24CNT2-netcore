using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PmqLesson10.Models;

public partial class PmqK24cnt2Lesson10Context : DbContext
{
    public PmqK24cnt2Lesson10Context()
    {
    }

    public PmqK24cnt2Lesson10Context(DbContextOptions<PmqK24cnt2Lesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<PmqMember> PmqMembers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOP-N8I0ERNO\\SQLEXPRESS03;Database=PmqK24cnt2Lesson10;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PmqMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__PmqMembe__0CF04B18D6FD72FD");

            entity.ToTable("PmqMember");

            entity.HasIndex(e => e.PmqUserName, "UQ__PmqMembe__82A30A925D985531").IsUnique();

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.PmqEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PmqFullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PmqPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PmqPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PmqStatus).HasDefaultValue(true);
            entity.Property(e => e.PmqUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
