using BusinessLayer.BLL;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using cSharpEksamen.Presentation.Models;
using DataAccessLayer.Mapper;
using DataAccessLayer.Model;
using Microsoft.IdentityModel.Tokens;

namespace cSharpEksamen.Presentation.Controllers;

public class TidsregistreringController : Controller
{
    private readonly Context _db;

    private BLL _bll = new BLL();
    // GET
    public TidsregistreringController(Context db)
    {
        _db = db;
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Tidsregistreringer = _bll.hentAlleTidsregistreringer().ToList();
        ViewBag.Afdelinger = _bll.hentAlleAfdelinger().ToList();
        ViewBag.Medarbejdere = _bll.hentAlleMedarbejdere().ToList();
        ViewBag.Sager = _bll.hentAlleSager();
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    //Index udfører denne metode
    public IActionResult CreateTidsregistrering(int tidsregistreringId, DateTime startTid, DateTime slutTid, string medarbejderInitialer, int afdelingNr)
    {
        
        Console.WriteLine($"StartTid: {startTid}, SlutTid: {slutTid}");
        var tidsregistrering = new DTO.Model.Tidsregistrering(tidsregistreringId, startTid, slutTid, medarbejderInitialer, afdelingNr);
        _bll.tilfojTidsregistrering(tidsregistrering);
        
        _db.SaveChanges();
        ViewBag.Tidsregistreringer = _bll.hentAlleTidsregistreringer();
        return View(tidsregistrering);
    }
    
    public IActionResult Index()
    {
        ViewBag.Tidsregistreringer = _bll.hentAlleTidsregistreringer();
        ViewBag.Afdelinger = _bll.hentAlleAfdelinger();
        ViewBag.Medarbejdere = _bll.hentAlleMedarbejdere();
        ViewBag.Sager = _bll.hentAlleSager();
        
        return View();
    }
}