using System.Reflection.Metadata.Ecma335;
using DataAccessLayer.Context;
using DataAccessLayer.Mapper;
using DataAccessLayer.Model;
using Medarbejder = DTO.Model.Medarbejder;

namespace DataAccessLayer.Repository;

public class MedarbejderRepository
{
    public static Medarbejder hentMedarbejder(string initialer)
    {
        using (Context.Context context = new Context.Context())
        {
            return MedarbejderMapper.Map(context.Medarbejdere.Find(initialer));
        }
    } 
    
    public static void opretMedarbejder(Medarbejder medarbejder)
    {
        using (Context.Context context = new Context.Context())
        {
            DataAccessLayer.Model.Medarbejder datameMedarbejder = MedarbejderMapper.Map(medarbejder);
            context.Medarbejdere.Add(datameMedarbejder);
            context.SaveChanges();
        }
    }

    public static void opdaterMedarbejder(Medarbejder medarbejder)
    {
        using (Context.Context context = new Context.Context())
        {
            Model.Medarbejder dataMedarbejder = context.Medarbejdere.Find(medarbejder.Initialer);
            MedarbejderMapper.Update(medarbejder, dataMedarbejder);
            context.SaveChanges();
        }
    }
    
    public static void sletMedarbejder(Medarbejder medarbejder)
    {
        using (Context.Context context = new Context.Context())
        {
            DataAccessLayer.Model.Medarbejder dataMedarbejder = MedarbejderMapper.Map(medarbejder);
            context.Medarbejdere.Find(medarbejder.Initialer);
            context.Medarbejdere.Remove(dataMedarbejder);
            context.SaveChanges();
        }
    }

    public static List<Medarbejder> hentAlleMedarbejdere()
    {
        using (Context.Context context = new Context.Context())
        {
            List<Medarbejder> retur = new List<Medarbejder>();
            foreach (var m in context.Medarbejdere)
            {
                retur.Add(MedarbejderMapper.Map(m));
            }

            return retur;
        }
        

    }
    
}