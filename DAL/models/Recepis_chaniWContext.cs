using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.models
{
    public partial class Recepis_chaniWContext : DbContext
    {
        public Recepis_chaniWContext()
        {
        }

        public Recepis_chaniWContext(DbContextOptions<Recepis_chaniWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IngridentcRecpey> IngridentcRecpeys { get; set; } = null!;
        public virtual DbSet<Ingriduentce> Ingriduentces { get; set; } = null!;
        public virtual DbSet<Recepy> Recepies { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=kitotSrv\\sql;Database=Recepis_chaniW;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngridentcRecpey>(entity =>
            {
                entity.HasKey(e => e.CodeIingridRecpie);

                entity.ToTable("IngridentcRecpey");

                entity.HasOne(d => d.CodeIngr)
                    .WithMany(p => p.IngridentcRecpeys)
                    .HasForeignKey(d => d.CodeIngrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngridentcRecpey_Ingriduentce");

                entity.HasOne(d => d.CoderecpieyNavigation)
                    .WithMany(p => p.IngridentcRecpeys)
                    .HasForeignKey(d => d.Coderecpiey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngridentcRecpey_Recepies");
            });

            modelBuilder.Entity<Ingriduentce>(entity =>
            {
                entity.HasKey(e => e.CodeIngrid);

                entity.ToTable("Ingriduentce");

                entity.Property(e => e.NameIngrid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recepy>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Discrib)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Instruction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Levels)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meals)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeuserNavigation)
                    .WithMany(p => p.Recepies)
                    .HasForeignKey(d => d.Codeuser)
                    .HasConstraintName("FK_Recepies_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Codeusr);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
