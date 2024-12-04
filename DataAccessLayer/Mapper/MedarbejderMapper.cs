using System.ComponentModel;
using DataAccessLayer.Model;
using DTO.Model;
using Afdeling = DataAccessLayer.Model.Afdeling;
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
            Cpr = dtoMedarbejder.Cpr,
            Initialer = dtoMedarbejder.Initialer
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
    
    
}