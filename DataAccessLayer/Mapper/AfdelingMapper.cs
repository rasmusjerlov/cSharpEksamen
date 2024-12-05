using DataAccessLayer.Model;

namespace DataAccessLayer.Mapper;

internal class AfdelingMapper
{
    public static DTO.Model.Afdeling Map(Afdeling afdeling)
    {
        return new DTO.Model.Afdeling(afdeling.AfdelingNavn, afdeling.AfdelingNr);
    }
    
    public static Afdeling Map(DTO.Model.Afdeling dtoAfdeling)
    {
        return new Afdeling
        {
            AfdelingNavn = dtoAfdeling.AfdelingNavn,
            AfdelingNr = dtoAfdeling.AfdelingNr
        };
    }

    internal static void Update(DTO.Model.Afdeling afdeling, Afdeling dataAfdeling)
    {
        dataAfdeling.AfdelingNr = afdeling.AfdelingNr;
        dataAfdeling.AfdelingNavn = afdeling.AfdelingNavn;
    }
    
    private static List<DTO.Model.Afdeling> Map(List<Afdeling> afdelinger)
    {
        List<DTO.Model.Afdeling> retur = new List<DTO.Model.Afdeling>();
        foreach (Afdeling a in afdelinger)
        {
            retur.Add(AfdelingMapper.Map(a));
        }

        return retur;
    }
}