namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class TipoCorsoConfiguration : IEntityTypeConfiguration<TipoCorso>
    {
        public void Configure(EntityTypeBuilder<TipoCorso> builder)
        {
            builder.HasKey(tc => tc.IDTipoCorso);
            builder.Property(tc => tc.TipoCorsoNome).IsRequired();
        }
    }

}
