using GolfV10.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfV10.Server.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<G120Player> Players { get; set; }
        public DbSet<G128Hcp> Hcps { get; set; }
        public DbSet<G136Foto> Fotos { get; set; }
        public DbSet<G170Campo> Campos { get; set; }
        public DbSet<G172Bandera> Banderas { get; set; }
        public DbSet<G176Hoyo> Hoyos { get; set; }
        public DbSet<G178Distancia> Distancias { get; set; }
        public DbSet<G190Bitacora> Bitacoras { get; set; }
        public DbSet<G194Cita> Appointments { get; set; }
        public DbSet<G200Torneo> Torneos { get; set; }
        public DbSet<G202CapturaTorneo> CapturasTorneo { get; set; }
        public DbSet<G204FechaTorneo> FechasTorneo { get; set; }
        public DbSet<G208CategoriaTorneo> CategoriasTorneo { get; set; }
        public DbSet<G220TeamTorneo> TeamsTorneo { get; set; }
        public DbSet<G222PlayerTorneo> PlayerTorneo { get; set; }
        public DbSet<G224RolTorneo> RolesTorneo { get; set; }
        public DbSet<G240Score> Scores { get; set; }
        public DbSet<G280FormatoTorneo> FormatosTorneo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
