using System.ComponentModel.DataAnnotations;

namespace DTO.Model;

public class AfdelingOverview
{
    public string AfdelingsNavn { get; set; }
    [Key]
    public int AfdelingsNr { get; set; }

    public AfdelingOverview(string afdelingsNavn, int afdelingsNr)
    {
        AfdelingsNavn = afdelingsNavn;
        AfdelingsNr = afdelingsNr;
    }

    public AfdelingOverview()
    {
    }
}