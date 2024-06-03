using System;
using System.Collections.Generic;
using ABM_CLIENTES.Models;
using Microsoft.EntityFrameworkCore;

namespace ABM_CLIENTES.Data;

public partial class AbmClientesContext : DbContext
{
    public AbmClientesContext()
    {
    }

    public AbmClientesContext(DbContextOptions<AbmClientesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__CLIENTES__23A341304DB051F9");

            entity.ToTable("CLIENTES");

            entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NumCliente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NUM_CLIENTE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
