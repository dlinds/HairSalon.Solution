using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class HaircutTypesController : Controller
  {
    private readonly HairSalonContext _db;

    public HaircutTypesController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageName = "Haircut Types";
      List<HaircutType> model = _db.HaircutTypes.OrderBy(model => model.Name).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.PageName = "Add Haircut Type";
      return View();
    }

    [HttpPost]
    public ActionResult Create(HaircutType haircutType)
    {
      _db.HaircutTypes.Add(haircutType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int deleteHaircutType)
    {
      HaircutType thisHaircut = _db.HaircutTypes.FirstOrDefault(haircutType => haircutType.HaircutTypeId == deleteHaircutType);
      _db.HaircutTypes.Remove(thisHaircut);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }

}