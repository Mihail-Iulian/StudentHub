namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class DipartimentoConfiguration : IEntityTypeConfiguration<Dipartimento>
    {
        public void Configure(EntityTypeBuilder<Dipartimento> builder)
        {
            builder.HasKey(d => d.IDDipartimento);
            builder.Property(d => d.NomeDipartimento).IsRequired();
            builder.HasOne(d => d.Facolta)
                   .WithMany(f => f.Dipartimenti)
                   .HasForeignKey(d => d.IDFacolta);
        }
    }

}
