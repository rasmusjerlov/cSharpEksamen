namespace DTO.Model;

public class Tidsregistrering
{
    public int TidsregistreringId { get; set; }
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public int? SagId { get; set; }
    public Sag? Sag { get; set; }
    public Afdeling Afdeling { get; set; }
    public string MedarbejderInitialer { get; set; }
    public int AfdelingNr { get; set; }
    public Medarbejder Medarbejder { get; set; }

    public Tidsregistrering(int tidsregistreringId, DateTime startTid, DateTime slutTid, string medarbejderInitialer, int afdelingNr)
    {
        this.TidsregistreringId = tidsregistreringId;
        this.StartTid = startTid;
        this.SlutTid = slutTid;
        this.MedarbejderInitialer = medarbejderInitialer;
        this.AfdelingNr = afdelingNr;
    }

    public Tidsregistrering()
    {
    }
    
    // public void setSag(Sag sag)
    // {
    //     if (!sag.TidsregistreringerList.Contains(this))
    //     {
    //         sag.TidsregistreringerList.Add(this);
    //     }
    // }
}