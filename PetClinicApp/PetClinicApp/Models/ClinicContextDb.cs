using Microsoft.EntityFrameworkCore;
using PetClinicApp.Models;

public class ClinicContextDb : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Passport> Passports { get; set; }
    public DbSet<Vet> Vets { get; set; }
    public DbSet<Procedure> Procedures { get; set; }
    public DbSet<AnimalAid> AnimalAids { get; set; }
    public DbSet<ProcedureAnimalAid> ProcedureAnimalAids { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProcedureAnimalAid>()
            .HasKey(paa => new { paa.ProcedureId, paa.AnimalAidId });

        modelBuilder.Entity<AnimalAid>()
            .Property(aa => aa.Price)
            .HasPrecision(18, 2); 

        modelBuilder.Entity<Procedure>()
            .Property(p => p.Cost)
            .HasPrecision(18, 2);  

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=Naim;Database=VetClinicDb;Integrated Security=True;TrustServerCertificate=true");
    }
}