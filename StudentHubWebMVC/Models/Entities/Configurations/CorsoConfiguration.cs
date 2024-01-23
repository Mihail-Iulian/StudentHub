namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class CorsoConfiguration : IEntityTypeConfiguration<Corso>
    {
        public void Configure(EntityTypeBuilder<Corso> builder)
        {
            builder.HasKey(c => c.IDCorso);
            builder.Property(c => c.NomeCorso).IsRequired();
            builder.HasOne(c => c.Dipartimento)
                   .WithMany(d => d.Corsi)
                   .HasForeignKey(c => c.IDDipartimento);
            builder.HasOne(c => c.TipoCorso)
                   .WithMany(tc => tc.Corsi)
                   .HasForeignKey(c => c.IDTipoCorso);
        }
    }

}