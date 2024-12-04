using DTO.Model;
using Sag = DataAccessLayer.Model.Sag; 
namespace DataAccessLayer.Mapper;

internal class SagMapper
{
    public static DTO.Model.Sag Map(Sag sag)
    {
        return new DTO.Model.Sag(sag.SagId, sag.Overskrift, sag.Beskrivelse);
    }
    public static Sag Map(DTO.Model.Sag dtoSag)
    {
        return new Sag
        {
            SagId = dtoSag.SagId,
            Overskrift = dtoSag.Overskrift,
            Beskrivelse = dtoSag.Beskrivelse
        };
    }
    internal static void Update(DTO.Model.Sag sag, Sag dataSag)
    {
        dataSag.SagId = sag.SagId;
        dataSag.Overskrift = sag.Overskrift;
        dataSag.Beskrivelse = sag.Beskrivelse;
    }
    
    private static List<DTO.Model.Sag> Map(List<Sag> sag)
    {
        List<DTO.Model.Sag> retur = new List<DTO.Model.Sag>();
        foreach (Sag s in sag)
        {
            retur.Add(SagMapper.Map(s));
        }

        return retur;
    }
}