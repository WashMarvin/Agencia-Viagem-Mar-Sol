using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaMareSol.Models
{
    public class Context : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Destino> Destinos { get; set; }

        public DbSet<Passagem> Passagens { get; set; }

        public DbSet<Promocao> Promoções { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AGMareSol;Data Source=DESKTOP-PFHLVPM\\SQLEXPRESS");
        }
    }
}
