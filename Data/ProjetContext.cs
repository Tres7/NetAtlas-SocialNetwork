#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet.Models;

namespace Projet.Data
{
    public class ProjetContext : DbContext
    {
        public ProjetContext (DbContextOptions<ProjetContext> options)
            : base(options)
        {
        }

        public DbSet<Projet.Models.Inscription> Inscription { get; set; }

        public DbSet<Projet.Models.Login> Login { get; set; }

        public DbSet<Projet.Models.Chat> Chat { get; set; }
    }
}
