using DataAccessLayer.Mapper;
using DTO.Model;

namespace DataAccessLayer.Repository;

public class TidsregistreringRepository
{
    public static Tidsregistrering hentTidsregistrering(int tidsregistreringId)
    {
        using (Context.Context context = new Context.Context())
        {
            return TidsregistreringMapper.Map(context.Tidsregistreringer.Find(tidsregistreringId));
        }
    }
    
    public static void tilfojTidsregistrering(Tidsregistrering tidsregistrering)
    {
        using (Context.Context context = new Context.Context())
        {
            DataAccessLayer.Model.Tidsregistrering dataTidsregistrering = TidsregistreringMapper.Map(tidsregistrering);
            context.Tidsregistreringer.Add(dataTidsregistrering);
            context.SaveChanges();
        }
    }
    
    public static void opdaterTidsregistrering(Tidsregistrering tidsregistrering)
    {
        using (Context.Context context = new Context.Context())
        {
            Model.Tidsregistrering dataTidsregistrering = context.Tidsregistreringer.Find(tidsregistrering.TidsregistreringId);
            TidsregistreringMapper.Update(tidsregistrering, dataTidsregistrering);
            context.SaveChanges();
        }
    }
    
    public static List<Tidsregistrering> hentAlleTidsregistreringer()
    {
        using (Context.Context context = new Context.Context())
        {
            return context.Tidsregistreringer
                .Select(t => TidsregistreringMapper.Map(t))
                .ToList();
        }
    }
}