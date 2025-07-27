using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        
        public DbSet<Usuario> Usuarios { get; set; } 

        public ExoContext() { }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;");
            }
        }
    }
}
