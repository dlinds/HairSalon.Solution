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
      ViewBag.ListOfHaircuts = _db.HaircutTypes.ToList();
      ViewBag.ListOfStylists = _db.Stylists.ToList();
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "FirstName");
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageName = "Add Customer";
      ViewBag.ListOfHaircuts = _db.HaircutTypes.ToList();
      ViewBag.ListOfStylists = _db.Stylists.ToList();
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "FirstName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Customer customer)
    {
      _db.Customers.Add(customer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult Edit(Customer customer)
    {
      _db.Entry(customer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult Delete(int deleteCustomerId)
    {
      Customer thisCustomer = _db.Customers.FirstOrDefault(customer => customer.CustomerId == deleteCustomerId);
      _db.Customers.Remove(thisCustomer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}