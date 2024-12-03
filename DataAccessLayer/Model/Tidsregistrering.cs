using cSharpEksamen.Models;

namespace DataAccessLayer.Model;

internal class Tidsregistrering
{
    public DateTime startTid { get; set; }
    public DateTime slutTid { get; set; }
    public Medarbejder medarbejder { get; set; }

    public Tidsregistrering(DateTime startTid, DateTime slutTid, Medarbejder medarbejder)
    {
        this.startTid = startTid;
        this.slutTid = slutTid;
        this.medarbejder = medarbejder;
    }
}