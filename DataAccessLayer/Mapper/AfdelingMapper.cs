using DataAccessLayer.Model;

namespace DataAccessLayer.Mapper;

internal class AfdelingMapper
{
    public static DTO.Model.Afdeling Map(Afdeling afdeling)
    {
        return new DTO.Model.Afdeling(afdeling.AfdelingsNavn, afdeling.AfdelingsNr);
    }
    
    public static Afdeling Map(DTO.Model.Afdeling dtoAfdeling)
    {
        return new Afdeling
        {
            AfdelingsNavn = dtoAfdeling.AfdelingsNavn,
            AfdelingsNr = dtoAfdeling.AfdelingsNr
        };
    }

    internal static void Update(DTO.Model.Afdeling afdeling, Afdeling dataAfdeling)
    {
        dataAfdeling.AfdelingsNr = afdeling.AfdelingsNr;
        dataAfdeling.AfdelingsNavn = afdeling.AfdelingsNavn;
    }
    
    private static List<DTO.Model.Afdeling> Map(List<Afdeling> afdeling)
    {
        List<DTO.Model.Afdeling> retur = new List<DTO.Model.Afdeling>();
        foreach (Afdeling a in afdeling)
        {
            retur.Add(AfdelingMapper.Map(a));
        }

        return retur;
    }
}