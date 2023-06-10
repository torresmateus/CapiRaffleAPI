using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CapiRaffle.MODEL;

public partial class CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersAdminSourceReposCapiraffleCapiraffleDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comprador> Compradors { get; set; }

    public virtual DbSet<Rifa> Rifas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\CapiRaffle\\CapiRaffle.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comprador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comprado__3214EC0739036D35");

            entity.ToTable("Comprador");

            entity.Property(e => e.CpfComprador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cpf_comprador");
            entity.Property(e => e.IdRifa).HasColumnName("id_rifa");
            entity.Property(e => e.NomeComprador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_comprador");
            entity.Property(e => e.Numeros)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeros");

            entity.HasOne(d => d.IdRifaNavigation).WithMany(p => p.Compradors)
                .HasForeignKey(d => d.IdRifa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rifa_comprador");
        });

        modelBuilder.Entity<Rifa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rifa__3214EC07AEFF69C7");

            entity.ToTable("Rifa");

            entity.Property(e => e.CpfCriador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cpf_criador");
            entity.Property(e => e.DataTermino)
                .HasColumnType("date")
                .HasColumnName("data_termino");
            entity.Property(e => e.NomeCriador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_criador");
            entity.Property(e => e.NomeRifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_rifa");
            entity.Property(e => e.PixCriador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pix_criador");
            entity.Property(e => e.PremioRifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("premio_rifa");
            entity.Property(e => e.ValorRifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valor_rifa");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
