using Examen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Socio> Socios { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }
        public object Socio { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Socio>(z => {
                z.HasKey(a => a.Cedula);

                z.Property(a => a.Nombre)
                // .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);

                z.Property(a => a.Apellido)
                // .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);

                z.Property(a => a.Direccion)
                // .IsRequired()
                 .HasMaxLength(250)
                 .IsUnicode(false);

                z.Property(a => a.Estado)
                 //.IsRequired()
                 .IsUnicode(false);

                z.Property(a => a.Apellido)
              // .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);
            });

            base.OnModelCreating(builder);
            builder.Entity<Cuenta>(z => {
                z.HasKey(a => a.NumeroCuenta);

                z.Property(a => a.SaldoTotal)
                // .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);

                z.Property(a => a.Cedula)
                // .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);

                z.Property(a => a.CodigoSocio)
                // .IsRequired()
                 .HasMaxLength(10)
                 .IsUnicode(false);

                z.Property(a => a.Estado)
                 //.IsRequired()
                 .IsUnicode(false);
            });
        }

    }
}
