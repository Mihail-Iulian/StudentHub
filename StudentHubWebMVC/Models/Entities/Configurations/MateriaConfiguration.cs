namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(m => m.IDMateria);
            builder.Property(m => m.NomeMateria).IsRequired();
            builder.HasOne(m => m.Dipartimento)
                   .WithMany(d => d.Materie)
                   .HasForeignKey(m => m.IDDipartimento);
            builder.HasOne(m => m.SettoreScientificoDisciplinare)
                   .WithMany(ssd => ssd.Materie)
                   .HasForeignKey(m => m.IDSettoreScientificoDisciplinare);
        }
    }

}
