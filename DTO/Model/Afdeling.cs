namespace DTO.Model;

public class Afdeling
{
    public string AfdelingsNavn { get; set; }
    public int AfdelingsNr { get; set; }
    public List<Medarbejder> medarbejderList { get; set; } = new List<Medarbejder>();
}