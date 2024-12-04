using DataAccessLayer.Model;

namespace DataAccessLayer.Model;

public class Afdeling
{
    public string AfdelingNavn { get; set; }
    public int AfdelingNr { get; set; }
    public List<Medarbejder> medarbejderList { get; set; } = new List<Medarbejder>();
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
        return $"AfdelingsNavn: {AfdelingNavn}, AfdelingsNr: {AfdelingNr}";
    }
}