namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class StudenteConfiguration : IEntityTypeConfiguration<Studente>
    {
        public void Configure(EntityTypeBuilder<Studente> builder)
        {
            builder.HasKey(s => s.IDStudente);
            builder.Property(s => s.NomeStudente).IsRequired();
            builder.Property(s => s.CognomeStudente).IsRequired();
            builder.HasOne(s => s.Corso)
                   .WithMany(c => c.Studenti)
                   .HasForeignKey(s => s.IDCorso);
            builder.HasOne(s => s.Campus)
                   .WithMany(c => c.Studenti)
                   .HasForeignKey(s => s.IDCampus);
        }
    }

}
