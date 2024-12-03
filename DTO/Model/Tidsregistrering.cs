namespace DTO.Model;

public class Tidsregistrering
{
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public Sag sag { get; set; }

    public Tidsregistrering(DateTime startTid, DateTime slutTid)
    {
        this.StartTid = startTid;
        this.SlutTid = slutTid;
        
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