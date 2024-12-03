using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace cSharpEksamen.Controllers;

public class MedarbejderController : Controller
{
    private readonly MedarbejderContext _medarbejderContext;
    // GET
    public IActionResult MedarbejderView()
    {
        var medarbejdere = _medarbejderContext.Medarbejdere.ToList();
        return View(medarbejdere);
    }
}