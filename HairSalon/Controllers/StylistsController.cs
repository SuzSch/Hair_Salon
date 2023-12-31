using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

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
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      List<SelectListItem> specialities = new List<SelectListItem>
    {
        new SelectListItem { Value = "Short Hair", Text = "Short Hair" },
        new SelectListItem { Value = "Long Hair", Text = "Long Hair" },
        new SelectListItem { Value = "Curly Hair", Text = "Curly Hair" },
        new SelectListItem { Value = "Colorist", Text = "Colorist" }
    };

      ViewBag.SpecialityList = specialities;

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
      Stylist thisStylist = _db.Stylists
          .Include(stylist => stylist.Clients)
          .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);

      List<SelectListItem> specialities = new List<SelectListItem>
    {
        new SelectListItem { Value = "Short Hair", Text = "Short Hair" },
        new SelectListItem { Value = "Long Hair", Text = "Long Hair" },
        new SelectListItem { Value = "Curly Hair", Text = "Curly Hair" },
        new SelectListItem { Value = "Colorist", Text = "Colorist" }
    };
      ViewBag.SpecialityList = specialities;

      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Stylists.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}