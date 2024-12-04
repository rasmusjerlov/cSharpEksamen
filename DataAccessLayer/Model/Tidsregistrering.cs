
namespace DataAccessLayer.Model;

public class Tidsregistrering
{
    public int TidsregistreringId { get; set; }
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public Afdeling Afdeling { get; set; }
    public int SagId { get; set; }
    public Sag Sag { get; set; }
    public string MedarbejderInitialer { get; set; }
    public Medarbejder Medarbejder { get; set; }

    public Tidsregistrering(int tidsregistreringId, DateTime startTid, DateTime slutTid, Medarbejder medarbejder, Afdeling afdeling)
    {
        this.TidsregistreringId = tidsregistreringId;
        this.StartTid = startTid;
        this.SlutTid = slutTid;
        this.Medarbejder = medarbejder;
        this.Afdeling = afdeling;
    }

    public Tidsregistrering()
    {
    }
    
    
}