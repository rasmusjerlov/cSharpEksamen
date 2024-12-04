using System.Diagnostics;
using DataAccessLayer.Model;
using DataAccessLayer.Repository;
using Medarbejder = DataAccessLayer.Model.Medarbejder;
using Sag = DataAccessLayer.Model.Sag;
using Tidsregistrering = DataAccessLayer.Model.Tidsregistrering;
using Afdeling = DataAccessLayer.Model.Afdeling;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.Context;

public class Context : DbContext
{
    public DbSet<Afdeling> Afdelinger { get; set; }
    public DbSet<Medarbejder> Medarbejdere { get; set; }
    public DbSet<Sag> Sager { get; set; }
    public DbSet<Tidsregistrering> Tidsregistreringer { get; set; }

    public Context()
    {
        Database.EnsureDeleted();
        bool created = Database.EnsureCreated();
        if (created)
        {
            Debug.WriteLine("Database Created");
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433; " +
            "Database=cSharpEksamenDB; " +
            "User=SA; " +
            "Password=SuperAvocado5; " +
            "TrustServerCertificate=True; " +
            "MultipleActiveResultSets=True");
        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medarbejder>().HasKey(m => m.Initialer);
        modelBuilder.Entity<Medarbejder>().HasData(new Medarbejder[] {
            new Medarbejder {Navn = "Mikkel", Cpr = "123123123123", Initialer = "MA"},  
            new Medarbejder {Navn = "Abu", Cpr = "123123123123", Initialer = "AB"},
            new Medarbejder {Navn = "Mark", Cpr = "151203813", Initialer = "MK"},
            new Medarbejder {Navn = "Tully", Cpr = "840852093482", Initialer = "TU"},
            new Medarbejder {Navn = "Rasmus", Cpr = "840852093482", Initialer = "RA"}
        });
        
        modelBuilder.Entity<Afdeling>().HasKey(a => a.AfdelingNr);
        modelBuilder.Entity<Afdeling>().HasData(new Afdeling[] {
            new Afdeling {AfdelingNavn = "IT", AfdelingNr = 1},
            new Afdeling {AfdelingNavn = "HR", AfdelingNr = 2},
            new Afdeling {AfdelingNavn = "Salg", AfdelingNr = 3}
        });
        
        modelBuilder.Entity<Sag>().HasKey(s => s.SagId);
        modelBuilder.Entity<Sag>()
            .HasOne(s => s.Afdeling)
            .WithMany(a => a.Sager)
            .HasForeignKey(s => s.AfdelingsNr)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Sag>().HasData(new Sag[] {
            new Sag {SagId = 1, Overskrift = "Sag1", Beskrivelse = "Sag for IT afdeling", AfdelingsNr = 1},
            new Sag {SagId = 2, Overskrift = "Sag2", Beskrivelse = "Sag for HR afdeling", AfdelingsNr = 2},
            new Sag {SagId = 3, Overskrift = "Sag3", Beskrivelse = "Sag for salgsafdeling", AfdelingsNr = 3}
        });
        
        modelBuilder.Entity<Tidsregistrering>().HasKey(t => t.TidsregistreringId);
        modelBuilder.Entity<Tidsregistrering>()
            .HasOne(t => t.Medarbejder)
            .WithMany(m => m.Tidsregistreringer)
            .HasForeignKey(t => t.MedarbejderInitialer)
            .OnDelete(DeleteBehavior.Restrict);

    }
    
}