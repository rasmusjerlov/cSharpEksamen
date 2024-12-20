
namespace DataAccessLayer.Model
{
    

public class Medarbejder
{
    public string Navn { get; set; }
    public string Cpr { get; set; }
    public string Initialer { get; set; }
    public List<Afdeling> Afdelinger { get; set; } = new List<Afdeling>();
    public ICollection<Tidsregistrering> Tidsregistreringer { get; set; }

    public Medarbejder()
    {
    }

    public Medarbejder(string navn, string cpr, string initialer)
    {
        Navn = navn;
        Cpr = cpr;
        Initialer = initialer;
    }

    public override string ToString()
    {
        return $"Navn: {Navn}, CPR: {Cpr}, Initialer: {Initialer}";
    }
}
}
