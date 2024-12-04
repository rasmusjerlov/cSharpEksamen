using DataAccessLayer.Model;

namespace DataAccessLayer.Mapper;

internal class TidsregistreringMapper
{
    public static DTO.Model.Tidsregistrering Map(Tidsregistrering tidsregistrering)
    {
        return new DTO.Model.Tidsregistrering(tidsregistrering.TidsregistreringId, tidsregistrering.StartTid, tidsregistrering.SlutTid, MedarbejderMapper.Map(tidsregistrering.Medarbejder));
    }

    public static Tidsregistrering Map(DTO.Model.Tidsregistrering dtoTidsregistrering)
    {
        return new Tidsregistrering
        {
            StartTid = dtoTidsregistrering.StartTid,
            SlutTid = dtoTidsregistrering.SlutTid
        };
    }
    
    internal static void Update(DTO.Model.Tidsregistrering tidsregistrering, Tidsregistrering dataTidsregistrering)
    {
        dataTidsregistrering.StartTid = tidsregistrering.StartTid;
        dataTidsregistrering.SlutTid = tidsregistrering.SlutTid;
    }
    
    private static List<DTO.Model.Tidsregistrering> Map(List<Tidsregistrering> tidsregistrering)
    {
        List<DTO.Model.Tidsregistrering> retur = new List<DTO.Model.Tidsregistrering>();
        foreach (Tidsregistrering t in tidsregistrering)
        {
            retur.Add(TidsregistreringMapper.Map(t));
        }

        return retur;
    }
}