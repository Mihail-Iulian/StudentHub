using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentHubWebMVC.Models;
using StudentHubWebMVC.Models.Entities;

namespace StudentHubWebMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<StudentHubWebMVC.Models.Entities.ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your other entities
        public DbSet<Campus> Campus { get; set; }
        public DbSet<Corso> Corsi { get; set; }
        public DbSet<Dipartimento> Dipartimeti { get; set; }
        public DbSet<Facolta> Facolta { get; set; }
        public DbSet<Materia> Materie { get; set; }
        public DbSet<SettoreScientificoDisciplinare> SettoriScientificiDisciplinari { get; set; }
        public DbSet<Studente> Studenti { get; set;}
        public DbSet<TipoCorso> TipiCorso { get; set; }
        public DbSet<VotoMateria> VotiMateria { get; set; }
        public DbSet<VotoTesi> VotiTesi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfigurations.ApplyAllConfigurations(modelBuilder);
        }

    }
}
