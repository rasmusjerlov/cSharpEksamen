namespace DataAccessLayer.Model;

public class Sag
{
    public int SagId { get; set; }
    public string Overskrift { get; set; }
    public string Beskrivelse { get; set; }
    public int AfdelingsNr { get; set; }
    public Afdeling Afdeling { get; set; }
    public ICollection<Tidsregistrering> Tidsregistreringer { get; set; }

    public Sag(int sagid, string overskrift, string beskrivelse)
    {
        SagId = sagid;
        Overskrift = overskrift;
        Beskrivelse = beskrivelse;
    }

    public Sag()
    {
    }

    public void tilfojTidsregistrering(Tidsregistrering tidsregistrering)
    {
        if (!Tidsregistreringer.Contains(tidsregistrering))
        {
            Tidsregistreringer.Add(tidsregistrering);
        }
    }

    
}