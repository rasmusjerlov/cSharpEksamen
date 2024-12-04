using System.ComponentModel.DataAnnotations;

namespace DTO.Model;

public class Medarbejder
{
    public string Navn { get; set; }
    public string Cpr { get; set; }
    
    public string Initialer { get; set; }

    public Medarbejder()
    {
    }

    public Medarbejder(string navn, string cpr, string initialer)
    {
        Navn = navn;
        Cpr = cpr;
        Initialer = initialer;
    }
    
}