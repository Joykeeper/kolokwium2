using Kol2Preparation.Models;
using Microsoft.EntityFrameworkCore;

namespace Kol2Preparation.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Patient>(entity =>
        // {
        //     entity.ToTable("Patient");
        //     entity.HasKey(e => e.IdPatient); // PK
        //     entity.Property(e => e.FirstName)
        //         .IsRequired()
        //         .HasMaxLength(100);
        //     entity.Property(e => e.LastName)
        //         .IsRequired()
        //         .HasMaxLength(100);
        //     entity.Property(e => e.Birthdate)
        //         .IsRequired();
        //     entity.HasMany(e => e.Prescriptions) // 1 to many
        //         .WithOne(e => e.Patient)
        //         .HasForeignKey(e => e.IdPatient);
        // });
        
        // modelBuilder.Entity<PrescriptionMedicament>(entity => // association table
        // {
        //     entity.ToTable("Prescription_Medicament");
        //     entity.HasKey(e => new {e.IdMedicament, e.IdPrescription});
        //     entity.Property(e => e.Dose)
        //         .HasMaxLength(100);
        //     entity.Property(e => e.Details)
        //         .IsRequired()
        //         .HasMaxLength(100);
        // });
    }
}