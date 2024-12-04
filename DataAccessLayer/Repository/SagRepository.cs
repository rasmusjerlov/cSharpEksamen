using DataAccessLayer.Mapper;
using DTO.Model;

namespace DataAccessLayer.Repository;

public class SagRepository
{
    public static Sag hentSag(int sagsnr)
    {
        using (Context.Context context = new Context.Context())
        {
            return SagMapper.Map(context.Sager.Find(sagsnr));
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
            Model.Sag dataSag = context.Sager.Find(sag.Sagsnr);
            SagMapper.Update(sag, dataSag);
            context.SaveChanges();
        }
    }
    public static List<Sag> hentAlleSager()
    {
        using (Context.Context context = new Context.Context())
        {
            return context.Sager
                .Select(s => SagMapper.Map(s))
                .ToList();
        }
    }
}