namespace DTO.Model;

public class Afdeling
{
    public string AfdelingNavn { get; set; }
    public int AfdelingNr { get; set; }
    public List<Medarbejder> medarbejdere { get; set; } = new List<Medarbejder>();
    public ICollection<Sag> Sager { get; set; }

    public Afdeling(string afdelingNavn, int afdelingNr)
    {
        AfdelingNavn = afdelingNavn;
        AfdelingNr = afdelingNr;
    }

    public Afdeling()
    {
    }
}