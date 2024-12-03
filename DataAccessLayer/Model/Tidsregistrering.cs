
namespace DataAccessLayer.Model;

public class Tidsregistrering
{
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public Medarbejder Medarbejder { get; set; }
    public Sag sag { get; set; }

    public Tidsregistrering(DateTime startTid, DateTime slutTid, Medarbejder medarbejder)
    {
        this.StartTid = startTid;
        this.SlutTid = slutTid;
        this.Medarbejder = medarbejder;
    }

    public Tidsregistrering()
    {
    }
    
    public void setSag(Sag sag)
    {
        if (!sag.TidsregistreringerList.Contains(this))
        {
            sag.TidsregistreringerList.Add(this);
        }
    }
}