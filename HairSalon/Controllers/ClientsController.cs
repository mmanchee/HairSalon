using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      System.Console.WriteLine(client.StylistId);
      return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
    }
    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      ViewBag.StylistName = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == thisClient.StylistId);
      return View(thisClient);
    }
    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName", thisClient.StylistId);
      return View(thisClient);
    }
    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = client.StylistId });
    }
  }
}