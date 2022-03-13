using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageName = "Stylists";
      List<Stylist> model = _db.Stylists.OrderBy(o => o.Position).ToList();
      ViewBag.ListOfHaircuts = _db.HaircutTypes.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageName = "Add New";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      ViewBag.PageName = thisStylist.FirstName + " " + thisStylist.LastName;
      ViewBag.CustomersList = _db.Customers.ToList();
      ViewBag.ListOfHaircuts = _db.HaircutTypes.ToList();
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult EditHairCutType(int haircutTypeId, int haircutTypeStylistId)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == haircutTypeStylistId);
      thisStylist.HaircutTypeId = haircutTypeId;
      _db.Entry(thisStylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = haircutTypeStylistId });
    }
    [HttpPost]
    public ActionResult EditHireDate(int hireDateStylistId, DateTime newHireDate)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == hireDateStylistId);
      thisStylist.HireDate = newHireDate;
      _db.Entry(thisStylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = hireDateStylistId });
    }
    [HttpPost]
    public ActionResult EditNumYears(int expYearsStylistId, int newExpYears)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == expYearsStylistId);
      thisStylist.PriorExperienceInYears = newExpYears;
      _db.Entry(thisStylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = expYearsStylistId });
    }

    [HttpPost]
    public ActionResult EditSchedule(int scheduleStylistId, TimeSpan shiftStart, TimeSpan shiftEnd, bool scheduledSunday, bool scheduledMonday, bool scheduledTuesday, bool scheduledWednesday, bool scheduledThursday, bool scheduledFriday, bool scheduledSaturday)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == scheduleStylistId);
      thisStylist.ShiftStart = shiftStart;
      thisStylist.ShiftEnd = shiftEnd;
      thisStylist.ScheduledSunday = scheduledSunday;
      thisStylist.ScheduledMonday = scheduledMonday;
      thisStylist.ScheduledTuesday = scheduledTuesday;
      thisStylist.ScheduledWednesday = scheduledWednesday;
      thisStylist.ScheduledThursday = scheduledThursday;
      thisStylist.ScheduledFriday = scheduledFriday;
      thisStylist.ScheduledSaturday = scheduledSaturday;
      _db.Entry(thisStylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = scheduleStylistId });
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int deleteStylistId)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == deleteStylistId);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }

}