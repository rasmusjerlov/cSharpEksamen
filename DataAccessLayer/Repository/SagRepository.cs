using System.Reflection.Metadata.Ecma335;
using DataAccessLayer.Mapper;
using DTO.Model;

namespace DataAccessLayer.Repository;

public class SagRepository
{
    public static Sag hentSag(int sagid)
    {
        using (Context.Context context = new Context.Context())
        {
            return SagMapper.Map(context.Sager.Find(sagid));
        }
    }
    
    public static void tilfojSag(Sag sag)
    {
        using (Context.Context context = new Context.Context())
        {
            DataAccessLayer.Model.Sag dataSag = SagMapper.Map(sag);
            context.Sager.Add(dataSag);
            context.SaveChanges();
        }
    }
    public static void opdaterSag(Sag sag)
    {
        using (Context.Context context = new Context.Context())
        {
            Model.Sag dataSag = context.Sager.Find(sag.SagId);
            SagMapper.Update(sag, dataSag);
            context.SaveChanges();
        }
    }
    
    public static void sletSag(Sag sag)
    {
        using (Context.Context context = new Context.Context())
        {
            DataAccessLayer.Model.Sag dataSag = SagMapper.Map(sag);
            context.Sager.Find(sag.SagId);
            context.Sager.Remove(dataSag);
            context.SaveChanges();
        }
    }
    public static List<Sag> hentAlleSager()
    {
        using (Context.Context context = new Context.Context())
        {
            List<Sag> retur = new List<Sag>();
            foreach (var sag in context.Sager)
            {
                retur.Add(SagMapper.Map(sag));
            }

            return retur;
        }
    }
}