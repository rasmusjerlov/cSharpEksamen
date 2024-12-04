namespace DataAccessLayer.Model;

public class Sag
{
    public int SagId { get; set; }
    public string Overskrift { get; set; }
    public string Beskrivelse { get; set; }
    
    public List<Tidsregistrering> TidsregistreringerList { get; set; }

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
        if (!TidsregistreringerList.Contains(tidsregistrering))
        {
            TidsregistreringerList.Add(tidsregistrering);
        }
    }

    
}