using System.Diagnostics;
using DataAccessLayer.Model;

using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.Context;

public class MedarbejderContext : DbContext
{
    public MedarbejderContext()
    {
        try
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database Created");
            }
        } catch (Exception e) 
        {
            Debug.WriteLine(e.Message);
        }
            
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=TidsregistreringsSystem; User=SA; Password=avocado5; TrustServerCertificate=true; MultiSubnetFailover=True");
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
    }
    
    public DbSet<Medarbejder> Medarbejdere { get; set; }
}