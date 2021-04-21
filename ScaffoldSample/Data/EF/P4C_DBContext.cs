using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ScaffoldSample.Data.EF
{
    public partial class P4C_DBContext : DbContext
    {
        public P4C_DBContext()
        {
        }

        public P4C_DBContext(DbContextOptions<P4C_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bomfile> Bomfiles { get; set; }
        public virtual DbSet<Bomviewer> Bomviewers { get; set; }
        public virtual DbSet<FileViewer> FileViewers { get; set; }
        public virtual DbSet<OtherFile> OtherFiles { get; set; }
        public virtual DbSet<PoorFile> PoorFiles { get; set; }
        public virtual DbSet<PoorViewer> PoorViewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-N5TF96M\\MSSQLSERVER2017;Database=P4C_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bomfile>(entity =>
            {
                entity.ToTable("BOMFiles");

                entity.Property(e => e.Blob).IsRequired();

                entity.Property(e => e.Guid).IsRequired();

                entity.Property(e => e.Owner).IsRequired();
            });

            modelBuilder.Entity<Bomviewer>(entity =>
            {
                entity.ToTable("BOMViewers");

                entity.Property(e => e.Bom).HasColumnName("BOM");

                entity.Property(e => e.ViewerName).IsRequired();

                entity.HasOne(d => d.BomNavigation)
                    .WithMany(p => p.Bomviewers)
                    .HasForeignKey(d => d.Bom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOMViewers_BOMFiles");
            });

            modelBuilder.Entity<FileViewer>(entity =>
            {
                entity.Property(e => e.ViewerName).IsRequired();

                entity.HasOne(d => d.OtherFileNavigation)
                    .WithMany(p => p.FileViewers)
                    .HasForeignKey(d => d.OtherFile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileViewers_OtherFiles");
            });

            modelBuilder.Entity<OtherFile>(entity =>
            {
                entity.Property(e => e.Blob).IsRequired();

                entity.Property(e => e.Guid).IsRequired();

                entity.Property(e => e.Owner).IsRequired();
            });

            modelBuilder.Entity<PoorFile>(entity =>
            {
                entity.Property(e => e.Blob).IsRequired();

                entity.Property(e => e.Bom).HasColumnName("BOM");

                entity.Property(e => e.Guid).IsRequired();

                entity.Property(e => e.Owner).IsRequired();

                entity.Property(e => e.Path).IsRequired();

                entity.HasOne(d => d.BomNavigation)
                    .WithMany(p => p.PoorFiles)
                    .HasForeignKey(d => d.Bom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoorFiles_BOMFiles");
            });

            modelBuilder.Entity<PoorViewer>(entity =>
            {
                entity.Property(e => e.Poor).HasColumnName("POOR");

                entity.Property(e => e.ViewerName).IsRequired();

                entity.HasOne(d => d.PoorNavigation)
                    .WithMany(p => p.PoorViewers)
                    .HasForeignKey(d => d.Poor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoorViewers_PoorFiles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
