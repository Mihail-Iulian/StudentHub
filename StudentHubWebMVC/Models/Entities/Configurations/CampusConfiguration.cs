namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class CampusConfiguration : IEntityTypeConfiguration<Campus>
    {
        public void Configure(EntityTypeBuilder<Campus> builder)
        {
            builder.HasKey(c => c.IDCampus);
            builder.Property(c => c.NomeCampus).IsRequired();
            builder.Property(c => c.Localita).IsRequired();
        }
    }

}
