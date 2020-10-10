using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Search(string searchType, string searchText)
    {
      if (searchType == "stylist")
      {
        return RedirectToAction("Search", "Stylists", new { search = searchText });
      }
      else
      {
        return RedirectToAction("Search", "Clients", new { search = searchText });
      }
    }
  }
}