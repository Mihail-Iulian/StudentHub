namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class FacoltaConfiguration : IEntityTypeConfiguration<Facolta>
    {
        public void Configure(EntityTypeBuilder<Facolta> builder)
        {
            builder.HasKey(f => f.IDFacolta);
            builder.Property(f => f.NomeFacolta).IsRequired();
        }
    }

}
