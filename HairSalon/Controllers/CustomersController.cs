using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class CustomersController : Controller
  {
    private readonly HairSalonContext _db;

    public CustomersController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageName = "Customers";
      List<Customer> model = _db.Customers.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageName = "Add Customer";
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "FirstName", "LastName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Customer customer)
    {
      _db.Customers.Add(customer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}