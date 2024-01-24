namespace StudentHubWebMVC.Models.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class VotoMateriaConfiguration : IEntityTypeConfiguration<VotoMateria>
    {
        public void Configure(EntityTypeBuilder<VotoMateria> builder)
        {
            builder.HasKey(vm => vm.IDVoto);
            builder.HasOne(vm => vm.Studente)
                   .WithMany(s => s.VotiMateriaStudente)
                   .HasForeignKey(vm => vm.IDStudente)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(vm => vm.Materia)
                   .WithMany(m => m.VotiMateria)
                   .HasForeignKey(vm => vm.IDMateria)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
