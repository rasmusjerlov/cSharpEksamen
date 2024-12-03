using DataAccessLayer.Repository;
using DTO.Model;

namespace BusinessLayer.BLL;

public class MedarbejderBLL
{
    public Medarbejder hentMedarbejder(string initialer)
    {
        return MedarbejderRepository.hentMedarbejder(initialer);
    }

    public void tilfojMedarbejder(Medarbejder medarbejder)
    {
        MedarbejderRepository.tilfojMedarbejder(medarbejder);
    }
    
    public void opdaterMedarbejder(Medarbejder medarbejder)
    {
        MedarbejderRepository.opdaterMedarbejder(medarbejder);
    }

    public List<Medarbejder> hentAlleMedarbejdere()
    {
        return MedarbejderRepository.hentAlleMedarbejdere();
    }
}