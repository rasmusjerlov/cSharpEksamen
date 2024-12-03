namespace DTO.Model;

public class AfdelingDetail
{
    public string AfdelingsNavn { get; set; }
    public int AfdelingsNr { get; set; }
    public List<Medarbejder> medarbejderList { get; set; } = new List<Medarbejder>();
}