using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh_IFXCLP.Models;

public partial class jatekosContext : DbContext
{
    public jatekosContext()
    {
    }

    public jatekosContext(DbContextOptions<jatekosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Jatekosok> Jatekosoks { get; set; }

    public virtual DbSet<Nemzetisegek> Nemzetisegeks { get; set; }

    public virtual DbSet<Posztok> Posztoks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ifxclp\\Desktop\\zh_IFXCLP\\zh_IFXCLP\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Jatekosok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jatekoso__3214EC272B12691C");

            entity.ToTable("Jatekosok");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NemzetisegId).HasColumnName("nemzetisegID");
            entity.Property(e => e.PosztId).HasColumnName("posztID");
            entity.Property(e => e.Sarga).HasColumnName("sarga");

            entity.HasOne(d => d.Nemzetiseg).WithMany(p => p.Jatekosoks)
                .HasForeignKey(d => d.NemzetisegId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jatekosok__nemze__3A81B327");

            entity.HasOne(d => d.Poszt).WithMany(p => p.Jatekosoks)
                .HasForeignKey(d => d.PosztId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jatekosok__poszt__3B75D760");
        });

        modelBuilder.Entity<Nemzetisegek>(entity =>
        {
            entity.HasKey(e => e.NemzetisegId).HasName("PK__Nemzetis__9A7B0C8AA739B3A2");

            entity.ToTable("Nemzetisegek");

            entity.Property(e => e.NemzetisegId)
                .ValueGeneratedNever()
                .HasColumnName("nemzetisegID");
            entity.Property(e => e.Nemzetiseg)
                .HasMaxLength(15)
                .HasColumnName("nemzetiseg");
        });

        modelBuilder.Entity<Posztok>(entity =>
        {
            entity.HasKey(e => e.PosztId).HasName("PK__Posztok__251D868558C63A89");

            entity.ToTable("Posztok");

            entity.Property(e => e.PosztId)
                .ValueGeneratedNever()
                .HasColumnName("posztID");
            entity.Property(e => e.Poszt)
                .HasMaxLength(15)
                .HasColumnName("poszt");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
