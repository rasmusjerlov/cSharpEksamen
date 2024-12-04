namespace DTO.Model;

public class Afdeling
{
    public string AfdelingsNavn { get; set; }
    public int AfdelingsNr { get; set; }
    public List<Medarbejder> medarbejderList { get; set; } = new List<Medarbejder>();
    public ICollection<Sag> Sager { get; set; }

    public Afdeling(string afdelingsNavn, int afdelingsNr)
    {
        AfdelingsNavn = afdelingsNavn;
        AfdelingsNr = afdelingsNr;
    }

    public Afdeling()
    {
    }
}