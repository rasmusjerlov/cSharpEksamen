using BusinessLayer.BLL;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        MedarbejderBLL bll = new MedarbejderBLL();
        bll.tilfojMedarbejder(new DTO.Model.Medarbejder("Jens", "JEN", "JE"));
    }
}