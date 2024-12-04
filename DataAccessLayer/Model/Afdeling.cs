using DataAccessLayer.Model;

namespace DataAccessLayer.Model;

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

    public void tilfojMedarbejder(Medarbejder medarbejder)
    {
        if (!medarbejderList.Contains(medarbejder))
        {
            medarbejderList.Add(medarbejder);
        }
    }

    public void fjernMedarbejder(Medarbejder medarbejder)
    {
        if (medarbejderList.Contains(medarbejder))
        {
            medarbejderList.Remove(medarbejder);
        }
    }

    public override string ToString()
    {
        return $"AfdelingsNavn: {AfdelingsNavn}, AfdelingsNr: {AfdelingsNr}";
    }
}