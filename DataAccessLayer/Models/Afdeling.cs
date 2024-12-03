namespace cSharpEksamen.Models;

public class Afdeling
{
    public string AfdelingsNavn { get; set; }
    public int AfdelingsNr { get; set; }
    public List<Medarbejder> Medarbejdere { get; set; } = new List<Medarbejder>();

    public Afdeling(string afdelingsNavn, int afdelingsNr)
    {
        AfdelingsNavn = afdelingsNavn;
        AfdelingsNr = afdelingsNr;
    }

    public override string ToString()
    {
        return $"AfdelingsNavn: {AfdelingsNavn}, AfdelingsNr: {AfdelingsNr}";
    }
}