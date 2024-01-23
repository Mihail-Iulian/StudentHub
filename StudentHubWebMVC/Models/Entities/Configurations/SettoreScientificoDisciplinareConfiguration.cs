namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class SettoreScientificoDisciplinareConfiguration : IEntityTypeConfiguration<SettoreScientificoDisciplinare>
    {
        public void Configure(EntityTypeBuilder<SettoreScientificoDisciplinare> builder)
        {
            builder.HasKey(ssd => ssd.IDSettoreScientificoDisciplinare);
            builder.Property(ssd => ssd.NomeSettoreScientificoDisciplinare).IsRequired();
            builder.Property(ssd => ssd.CodiceSettoreScientificoDisciplinare).IsRequired();
        }
    }

}
