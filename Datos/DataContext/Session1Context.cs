using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using Modelo;

namespace Datos.DataContext;

public partial class Session1Context : DbContext
{
    public Session1Context()
    {
    }

    public Session1Context(DbContextOptions<Session1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetaOrden> DetaOrdens { get; set; }

    public virtual DbSet<EstadoO> EstadoOs { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
         => optionsBuilder.UseMySql("server=localhost;user=root;database=Session1_if", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PRIMARY");

            entity.ToTable("categoria");

            entity.Property(e => e.IdCategoria)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_categoria");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PRIMARY");

            entity.ToTable("cliente");

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<DetaOrden>(entity =>
        {
            entity.HasKey(e => e.IdDeta).HasName("PRIMARY");

            entity.ToTable("deta_orden");

            entity.HasIndex(e => e.IdOr, "deta_orden_orden_fk");

            entity.HasIndex(e => e.IdProd, "deta_orden_productos_fk");

            entity.Property(e => e.IdDeta)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_deta");
            entity.Property(e => e.Cantidad)
                .HasPrecision(7, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdOr)
                .HasColumnType("int(11)")
                .HasColumnName("id_Or");
            entity.Property(e => e.IdProd)
                .HasColumnType("int(11)")
                .HasColumnName("id_prod");
            entity.Property(e => e.Precio)
                .HasPrecision(12, 2)
                .HasColumnName("precio");

            entity.HasOne(d => d.IdOrNavigation).WithMany(p => p.DetaOrdens)
                .HasForeignKey(d => d.IdOr)
                .HasConstraintName("deta_orden_orden_fk");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.DetaOrdens)
                .HasForeignKey(d => d.IdProd)
                .HasConstraintName("deta_orden_productos_fk");
        });

        modelBuilder.Entity<EstadoO>(entity =>
        {
            entity.HasKey(e => e.IdEstadoO).HasName("PRIMARY");

            entity.ToTable("estado_o");

            entity.Property(e => e.IdEstadoO)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_estadoO");
            entity.Property(e => e.NombreEsO)
                .HasMaxLength(50)
                .HasColumnName("nombre_Es_O");
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.HasKey(e => e.IdOrden).HasName("PRIMARY");

            entity.ToTable("orden");

            entity.HasIndex(e => e.IdCliente, "orden_cliente_fk");

            entity.HasIndex(e => e.IdEstado, "orden_estado_fk");

            entity.Property(e => e.IdOrden)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_orden");
            entity.Property(e => e.CantiTotal)
                .HasPrecision(7, 2)
                .HasColumnName("canti_total");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.IdEstado)
                .HasColumnType("int(11)")
                .HasColumnName("id_estado");
            entity.Property(e => e.Taxes)
                .HasPrecision(12, 2)
                .HasColumnName("taxes");
            entity.Property(e => e.Total)
                .HasPrecision(12, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("orden_cliente_fk");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("orden_estado_fk");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("PRIMARY");

            entity.ToTable("productos");

            entity.HasIndex(e => e.IdCategoria, "categoria_productos_fk");

            entity.Property(e => e.IdProd)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_prod");
            entity.Property(e => e.Activo)
                .HasColumnType("int(11)")
                .HasColumnName("activo");
            entity.Property(e => e.Costo)
                .HasPrecision(12, 2)
                .HasColumnName("costo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaIntro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_intro");
            entity.Property(e => e.IdCategoria)
                .HasColumnType("int(11)")
                .HasColumnName("id_categoria");
            entity.Property(e => e.NombreProd)
                .HasMaxLength(50)
                .HasColumnName("nombre_prod");
            entity.Property(e => e.Precio)
                .HasPrecision(12, 2)
                .HasColumnName("precio");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("categoria_productos_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
