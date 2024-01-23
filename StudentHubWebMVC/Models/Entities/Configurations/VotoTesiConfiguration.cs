namespace StudentHubWebMVC.Models.Entities.Configurations

{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class VotoTesiConfiguration : IEntityTypeConfiguration<VotoTesi>
    {
        public void Configure(EntityTypeBuilder<VotoTesi> builder)
        {
            builder.HasKey(vt => vt.IDVotoTesi);
            builder.HasOne(vt => vt.Studente)
                   .WithOne(s => s.VotoTesi)
                   .HasForeignKey<VotoTesi>(vt => vt.IDStudente);
        }
    }

}
