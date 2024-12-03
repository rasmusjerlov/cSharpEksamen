namespace DataAccessLayer.Model;

public class Sag
{
    public int Sagsnr { get; set; }
    public string Overskrift { get; set; }
    public string Beskrivelse { get; set; }
    public Afdeling Afdeling { get; set; }
    public List<Tidsregistrering> TidsregistreringerList { get; set; }

    public Sag(int sagsnr, string overskrift, string beskrivelse)
    {
        Sagsnr = sagsnr;
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

    public override string ToString()
    {
        return $"Sagsnr: {Sagsnr}, Overskrift: {Overskrift}, Beskrivelse: {Beskrivelse}, Afdeling: {Afdeling}, Tidsregistreringer: {TidsregistreringerList}";
    }
}