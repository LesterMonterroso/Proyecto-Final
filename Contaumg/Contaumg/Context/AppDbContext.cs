using Contaumg.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contaumg.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario_DB> Usuario { get; set; }

        public DbSet<Periodo> Periodo { get; set; }

        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Partida> Partida { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
    }

}
