using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using cSharpEksamen.Presentation.Models;
using DataAccessLayer.Mapper;
using DataAccessLayer.Model;
using Microsoft.IdentityModel.Tokens;

namespace cSharpEksamen.Presentation.Controllers;

public class TidsregistreringController : Controller
{
    private readonly Context _context;
    // GET
    public TidsregistreringController(Context context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Afdelinger = _context.Afdelinger.ToList();
        ViewBag.Medarbejdere = _context.Medarbejdere.ToList();
        ViewBag.Sager = _context.Sager.ToList();
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(TidsregistreringViewModel model)
    {
        if (ModelState.IsValid)
        {
            var tidsregistrering = new Tidsregistrering()
            {
                StartTid = model.StartTid,
                SlutTid = model.SlutTid,
                Afdeling = model.Afdeling,
                MedarbejderInitialer = model.MedarbejderInitialer,
                SagId = model.SagId
            };
            _context.Tidsregistreringer.Add(tidsregistrering);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Afdelinger = _context.Afdelinger.ToList();
        ViewBag.Medarbejdere = _context.Medarbejdere.ToList();
        ViewBag.Sager = _context.Sager.ToList();
        return View(model);
    }
    
    public IActionResult Index()
    {
        var viewModel = new TidsregistreringViewModel
        {
            Tidsregistreringer = _context.Tidsregistreringer.ToList()
        };
        
        ViewBag.Afdelinger = _context.Afdelinger.ToList();
        ViewBag.Medarbejdere = _context.Medarbejdere.ToList();
        ViewBag.Sager = _context.Sager.ToList();
        
        return View(viewModel);
    }
}