using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace cSharpEksamen.Controllers;

public class MedarbejderController : Controller
{
    private readonly Context _context;
    // GET
    public IActionResult MedarbejderView()
    {
        
        return View();
    }
}