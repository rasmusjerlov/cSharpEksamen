namespace DTO.Model;

public class Tidsregistrering
{
    public int TidsregistreringId { get; set; }
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public Sag sag { get; set; }
    public Medarbejder Medarbejder { get; set; }

    public Tidsregistrering(int tidsregistreringId, DateTime startTid, DateTime slutTid, Medarbejder medarbejder)
    {
        this.TidsregistreringId = tidsregistreringId;
        this.StartTid = startTid;
        this.SlutTid = slutTid;
        this.Medarbejder = medarbejder;
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