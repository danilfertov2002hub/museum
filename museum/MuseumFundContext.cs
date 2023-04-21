using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace museum;

public partial class MuseumFundContext : DbContext
{
    public MuseumFundContext()
    {
    }

    public MuseumFundContext(DbContextOptions<MuseumFundContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<MovingRecord> MovingRecords { get; set; }

    public virtual DbSet<Museum> Museums { get; set; }

    public virtual DbSet<Passport> Passports { get; set; }

    public virtual DbSet<Postt> Postts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;DataBase=MuseumFund;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.IdEmployee);

            entity.ToTable("Employee");

            entity.Property(e => e.IdEmployee).HasColumnName("idEmployee");
            entity.Property(e => e.Birthday)
                .HasColumnType("date")
                .HasColumnName("birthday");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.PassportId).HasColumnName("passportId");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PostId).HasColumnName("postId");
            entity.Property(e => e.Secondname)
                .HasMaxLength(50)
                .HasColumnName("secondname");

            entity.HasOne(d => d.Passport).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PassportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Passport");

            entity.HasOne(d => d.Post).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Postt");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.IdItem);

            entity.ToTable("Item");

            entity.Property(e => e.IdItem).HasColumnName("idItem");
            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .HasColumnName("age");
            entity.Property(e => e.MuseumId).HasColumnName("museumId");
            entity.Property(e => e.NameItem)
                .HasMaxLength(50)
                .HasColumnName("nameItem");
            entity.Property(e => e.StorageDate)
                .HasColumnType("date")
                .HasColumnName("storageDate");

            entity.HasOne(d => d.Museum).WithMany(p => p.Items)
                .HasForeignKey(d => d.MuseumId)
                .HasConstraintName("FK_Item_Museum");
        });

        modelBuilder.Entity<MovingRecord>(entity =>
        {
            entity.HasKey(e => e.IdRecord);

            entity.ToTable("MovingRecord");

            entity.Property(e => e.IdRecord).HasColumnName("idRecord");
            entity.Property(e => e.EndmuseumId).HasColumnName("endmuseumId");
            entity.Property(e => e.ItemId).HasColumnName("itemId");
            entity.Property(e => e.StartmuseumId).HasColumnName("startmuseumId");

            entity.HasOne(d => d.Endmuseum).WithMany(p => p.MovingRecordEndmuseums)
                .HasForeignKey(d => d.EndmuseumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovingRecord_Museum1");

            entity.HasOne(d => d.Item).WithMany(p => p.MovingRecords)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovingRecord_Item");

            entity.HasOne(d => d.Startmuseum).WithMany(p => p.MovingRecordStartmuseums)
                .HasForeignKey(d => d.StartmuseumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovingRecord_Museum");
        });

        modelBuilder.Entity<Museum>(entity =>
        {
            entity.HasKey(e => e.IdMuseum);

            entity.ToTable("Museum");

            entity.Property(e => e.IdMuseum).HasColumnName("idMuseum");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.NameMuseum)
                .HasMaxLength(50)
                .HasColumnName("nameMuseum");
        });

        modelBuilder.Entity<Passport>(entity =>
        {
            entity.HasKey(e => e.IdPassport);

            entity.ToTable("Passport");

            entity.Property(e => e.IdPassport).HasColumnName("idPassport");
            entity.Property(e => e.CodeDivision)
                .HasMaxLength(50)
                .HasColumnName("codeDivision");
            entity.Property(e => e.DateOfIssue)
                .HasColumnType("date")
                .HasColumnName("dateOfIssue");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.Series)
                .HasMaxLength(50)
                .HasColumnName("series");
        });

        modelBuilder.Entity<Postt>(entity =>
        {
            entity.HasKey(e => e.IdPost);

            entity.ToTable("Postt");

            entity.Property(e => e.IdPost).HasColumnName("idPost");
            entity.Property(e => e.NamePost)
                .HasMaxLength(50)
                .HasColumnName("namePost");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
