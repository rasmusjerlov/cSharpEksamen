namespace DTO.Model;

public class Sag
{
    public int Sagsnr { get; set; }
    public string Overskrift { get; set; }
    public string Beskrivelse { get; set; }
    public string Afdeling { get; set; }
    // public List<Tidsregistrering> TidsregistreringerList { get; set; }

    public Sag(int sagsnr, string overskrift, string beskrivelse)
    {
        Sagsnr = sagsnr;
        Overskrift = overskrift;
        Beskrivelse = beskrivelse;
    }

    public Sag()
    {
    }

}