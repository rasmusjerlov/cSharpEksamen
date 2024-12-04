using DataAccessLayer.Mapper;
using DataAccessLayer.Model;
using Afdeling = DTO.Model.Afdeling;
namespace DataAccessLayer.Repository;

public class AfdelingRepository
{
    public static Afdeling hentAfdeling(int afdelingsnr)
    {
        using (Context.Context context = new Context.Context())
        {
            return AfdelingMapper.Map(context.Afdelinger.Find(afdelingsnr));
        }
    }
    
    public static void tilfojAfdeling(Afdeling afdeling)
    {
        using (Context.Context context = new Context.Context())
        {
            DataAccessLayer.Model.Afdeling dataAfdeling = AfdelingMapper.Map(afdeling);
            context.Afdelinger.Add(dataAfdeling);
            context.SaveChanges();
        }
    }

    public static void opdaterAfdeling(Afdeling afdeling)
    {
        using (Context.Context context = new Context.Context())
        {
            Model.Afdeling dataAfdeling = context.Afdelinger.Find(afdeling.AfdelingsNr);
            AfdelingMapper.Update(afdeling, dataAfdeling);
            context.SaveChanges();
        }
    }

    public static List<Afdeling> hentAlleAfdelinger()
    {
        using (Context.Context context = new Context.Context())
        {
            return context.Afdelinger
                .Select(a => AfdelingMapper.Map(a))
                .ToList();
        }
    }
}