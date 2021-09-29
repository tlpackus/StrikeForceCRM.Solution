using Microsoft.AspNetCore.Mvc;

namespace StrikeForce.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
} 