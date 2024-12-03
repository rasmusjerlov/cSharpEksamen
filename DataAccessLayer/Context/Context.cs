using System.Diagnostics;
using DataAccessLayer.Model;
using DataAccessLayer.Repository;
using Medarbejder = DataAccessLayer.Model.Medarbejder;
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
        bool created = Database.EnsureCreated();
        if (created)
        {
            Debug.WriteLine("Database Created");
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433; Database=cSharpEksamen; User=SA; Password=SuperAvocado5; TrustServerCertificate=True; MultipleActiveResultSets=True");
        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medarbejder>().HasKey(m => m.Initialer);
        modelBuilder.Entity<Medarbejder>().HasData(new Medarbejder[] {
            new Medarbejder {Navn = "Mikkel", Cpr = "123123123123", Initialer = "MA"},  
            new Medarbejder {Navn = "Abu", Cpr = "123123123123", Initialer = "AB"},
            new Medarbejder {Navn = "Mark", Cpr = "151203813", Initialer = "MK"}
        });
        
        modelBuilder.Entity<Afdeling>().HasKey(a => a.AfdelingsNr);
        modelBuilder.Entity<Afdeling>().HasData(new Afdeling[] {
            new Afdeling {AfdelingsNavn = "IT", AfdelingsNr = 1},
            new Afdeling {AfdelingsNavn = "HR", AfdelingsNr = 2},
            new Afdeling {AfdelingsNavn = "Salg", AfdelingsNr = 3}
        });
        
        modelBuilder.Entity<Sag>().HasKey(s => s.Sagsnr);
        modelBuilder.Entity<Sag>().HasData(new Sag[] {
            new Sag {Sagsnr = 1, Overskrift = "Sag1", Beskrivelse = "Sag for IT afdeling"},
            new Sag {Sagsnr = 2, Overskrift = "Sag2", Beskrivelse = "Sag for HR afdeling"},
            new Sag {Sagsnr = 3, Overskrift = "Sag3", Beskrivelse = "Sag for salgsafdeling"}
        });
        
        // modelBuilder.Entity<Tidsregistrering>().HasData(new Tidsregistrering[] {
        //     new Tidsregistrering {StartTid = DateTime.Now, SlutTid = DateTime.Now.AddHours(10), },
        //     new Tidsregistrering {StartTid = DateTime.Now, SlutTid = DateTime.Now.AddHours(10), Medarbejder = new Medarbejder()},
        //     new Tidsregistrering {StartTid = DateTime.Now, SlutTid = DateTime.Now.AddHours(10), Medarbejder = new Medarbejder()}
        // });
        //
        // modelBuilder.Entity<Tidsregistrering>().HasOne(t => t.Medarbejder).WithMany().HasForeignKey(t => t.Medarbejder);
    }
    
}