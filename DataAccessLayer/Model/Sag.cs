namespace cSharpEksamen.Models;

internal class Sag
{
    public int Sagsnr { get; set; }
    public string Overskrift { get; set; }
    public string Beskrivelse { get; set; }
    public string Afdeling { get; set; }

    public Sag(int sagsnr, string overskrift, string beskrivelse, string afdeling)
    {
        Sagsnr = sagsnr;
        Overskrift = overskrift;
        Beskrivelse = beskrivelse;
        Afdeling = afdeling;
    }

    public override string ToString()
    {
        return $"Sagsnr: {Sagsnr}, Overskrift: {Overskrift}, Beskrivelse: {Beskrivelse}, Afdeling: {Afdeling}";
    }
}