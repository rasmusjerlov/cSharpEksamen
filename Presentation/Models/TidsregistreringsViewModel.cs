using DataAccessLayer.Model;

namespace cSharpEksamen.Presentation.Models;

public class TidsregistreringViewModel
{
    public int TidsregistreringId { get; set; }
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public string MedarbejderInitialer { get; set; }
    public int AfdelingNr { get; set; }
    
    public int SagId { get; set; }
    public IEnumerable<DTO.Model.Tidsregistrering> TidsregistreringerDto { get; set; }
    public IEnumerable<DataAccessLayer.Model.Tidsregistrering> Tidsregistreringer { get; set; }

    public TidsregistreringViewModel(int tidsregistreringId, DateTime startTid, DateTime slutTid, string medarbejderInitialer, int afdelingNr)
    {
        TidsregistreringId = tidsregistreringId;
        StartTid = startTid;
        SlutTid = slutTid;
        MedarbejderInitialer = medarbejderInitialer;
        AfdelingNr = afdelingNr;
    }

    public TidsregistreringViewModel()
    {
    }
}