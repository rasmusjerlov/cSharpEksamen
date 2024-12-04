using DataAccessLayer.Model;

namespace cSharpEksamen.Presentation.Models;

public class TidsregistreringViewModel
{
    public int TidsregistreringId { get; set; }
    public DateTime StartTid { get; set; }
    public DateTime SlutTid { get; set; }
    public string MedarbejderInitialer { get; set; }
    public Afdeling Afdeling { get; set; }
    
    public int SagId { get; set; }
    public ICollection<DataAccessLayer.Model.Tidsregistrering> Tidsregistreringer { get; set; }
    
}