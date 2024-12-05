using DataAccessLayer.Model;

namespace DataAccessLayer.Model;

public class Afdeling
{
    public string AfdelingNavn { get; set; }
    public int AfdelingNr { get; set; }
    public List<Tidsregistrering> Tidsregistreringer { get; set; } = new List<Tidsregistrering>();
    public List<Medarbejder> Medarbejdere { get; set; } = new List<Medarbejder>();
    public ICollection<Sag> Sager { get; set; }

    public Afdeling(string afdelingNavn, int afdelingNr)
    {
        AfdelingNavn = afdelingNavn;
        AfdelingNr = afdelingNr;
    }

    public Afdeling()
    {
    }

    public void tilfojMedarbejder(Medarbejder medarbejder)
    {
        if (!Medarbejdere.Contains(medarbejder))
        {
            Medarbejdere.Add(medarbejder);
        }
    }

    public void fjernMedarbejder(Medarbejder medarbejder)
    {
        if (Medarbejdere.Contains(medarbejder))
        {
            Medarbejdere.Remove(medarbejder);
        }
    }

    public override string ToString()
    {
        return $"AfdelingsNavn: {AfdelingNavn}, AfdelingsNr: {AfdelingNr}";
    }
}