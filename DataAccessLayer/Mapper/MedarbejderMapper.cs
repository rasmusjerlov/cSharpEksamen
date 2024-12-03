using System.ComponentModel;
using DataAccessLayer.Model;
using DTO.Model;
using Medarbejder = DataAccessLayer.Model.Medarbejder;

namespace DataAccessLayer.Mapper;
internal class MedarbejderMapper
{
    public static DTO.Model.Medarbejder Map(Medarbejder medarbejder)
    {
        return new DTO.Model.Medarbejder(medarbejder.Navn, medarbejder.Cpr, medarbejder.Initialer);
    }
    
    public static Medarbejder Map(DTO.Model.Medarbejder dtoMedarbejder)
    {
        return new Medarbejder
        {
            Navn = dtoMedarbejder.Navn,
            Cpr = dtoMedarbejder.Cpr
        };
    }

    internal static void Update(DTO.Model.Medarbejder medarbejder, Medarbejder dataMedarbejder)
    {
        dataMedarbejder.Navn = medarbejder.Navn;
        dataMedarbejder.Cpr = medarbejder.Cpr;
    }
    
    private static List<DTO.Model.Medarbejder> Map(List<Medarbejder> medarbejder)
    {
        List<DTO.Model.Medarbejder> retur = new List<DTO.Model.Medarbejder>();
        foreach (Medarbejder m in medarbejder)
        {
            retur.Add(MedarbejderMapper.Map(m));
        }

        return retur;
    }
    
    internal static DTO.Model.AfdelingDetail AfdelingDetail(Afdeling afdeling)
    {
        DTO.Model.AfdelingDetail retur = new DTO.Model.AfdelingDetail();
        retur.AfdelingsNavn = afdeling.AfdelingsNavn;
        retur.AfdelingsNr = afdeling.AfdelingsNr;
        retur.medarbejderList = MedarbejderMapper.Map(afdeling.medarbejderList);
        return retur;
    }
    
    public static DTO.Model.AfdelingOverview Map(Afdeling afdeling)
    {
        return new DTO.Model.AfdelingOverview(afdeling.AfdelingsNavn, afdeling.AfdelingsNr);
    }
    
    public static Afdeling Map(DTO.Model.AfdelingOverview dtoAfdeling)
    {
        return new Afdeling
        {
            AfdelingsNavn = dtoAfdeling.AfdelingsNavn,
            AfdelingsNr = dtoAfdeling.AfdelingsNr
        };
    }
}