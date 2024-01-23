namespace StudentHubWebMVC.Models
{
    using Microsoft.EntityFrameworkCore;
    using StudentHubWebMVC.Models.Entities.Configurations;

    public static class EntityConfigurations
    {

        public static void ApplyAllConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudenteConfiguration());
            modelBuilder.ApplyConfiguration(new FacoltaConfiguration());
            modelBuilder.ApplyConfiguration(new DipartimentoConfiguration());
            modelBuilder.ApplyConfiguration(new CorsoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoCorsoConfiguration());
            modelBuilder.ApplyConfiguration(new CampusConfiguration());
            modelBuilder.ApplyConfiguration(new MateriaConfiguration());
            modelBuilder.ApplyConfiguration(new SettoreScientificoDisciplinareConfiguration());
            modelBuilder.ApplyConfiguration(new VotoMateriaConfiguration());
            modelBuilder.ApplyConfiguration(new VotoTesiConfiguration());
            // ... add other configurations as needed
        }
    }
}

