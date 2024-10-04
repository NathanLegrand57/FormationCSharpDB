using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FormationCSharpDB.Class;

public partial class FormationCsharpDbContext : DbContext
{
    public FormationCsharpDbContext()
    {
    }

    public FormationCsharpDbContext(DbContextOptions<FormationCsharpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=FormationCSharpDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<School>(entity =>
        {
            entity.ToTable("School");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(75)
                .IsFixedLength();
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Firstname)
                .HasMaxLength(75)
                .IsFixedLength();
            entity.Property(e => e.Lastname)
                .HasMaxLength(75)
                .IsFixedLength();
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.ToTable("Teacher");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firstname)
                .HasMaxLength(75)
                .IsFixedLength();
            entity.Property(e => e.Lastname)
                .HasMaxLength(75)
                .IsFixedLength();
            entity.Property(e => e.Subject)
                .HasMaxLength(75)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
