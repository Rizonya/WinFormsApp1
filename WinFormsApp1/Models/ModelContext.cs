using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Заказчики> Заказчикиs { get; set; }

    public virtual DbSet<Заказы> Заказыs { get; set; }

    public virtual DbSet<Специалисты> Специалистыs { get; set; }

    public virtual DbSet<Услуги> Услугиs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mamaudali.accdb;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Код).HasName("PrimaryKey");

            entity.Property(e => e.Код).HasColumnType("counter");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<Заказчики>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Заказчики");

            entity.Property(e => e.Адрес).HasMaxLength(255);
            entity.Property(e => e.Заказчик).HasMaxLength(255);
            entity.Property(e => e.Номер).HasDefaultValueSql("0");
            entity.Property(e => e.НомерТелефона)
                .HasMaxLength(255)
                .HasColumnName("Номер_телефона");
        });

        modelBuilder.Entity<Заказы>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("Заказы");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("id");
            entity.Property(e => e.Адрес).HasMaxLength(255);
            entity.Property(e => e.ВидУслуги).HasColumnName("Вид услуги");
            entity.Property(e => e.Заказчик).HasMaxLength(255);
            entity.Property(e => e.Площадь).HasDefaultValueSql("0");
            entity.Property(e => e.Цена)
                .HasDefaultValueSql("0")
                .HasColumnType("currency");

            entity.HasOne(d => d.ВидУслугиNavigation).WithMany(p => p.Заказыs)
                .HasForeignKey(d => d.ВидУслуги)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("УслугиЗаказы");
        });

        modelBuilder.Entity<Специалисты>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("Специалисты");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("id");
            entity.Property(e => e.ИмяСпециалиста)
                .HasMaxLength(255)
                .HasColumnName("Имя специалиста");
            entity.Property(e => e.Стаж).HasMaxLength(255);
        });

        modelBuilder.Entity<Услуги>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.ToTable("Услуги");

            entity.HasIndex(e => e.ВидУслуги, "УслугиВид услуги");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("id");
            entity.Property(e => e.ВидУслуги).HasColumnName("Вид услуги");
            entity.Property(e => e.ЦенаЗаКвМ)
                .HasDefaultValueSql("0")
                .HasColumnType("currency")
                .HasColumnName("Цена за кв м");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
