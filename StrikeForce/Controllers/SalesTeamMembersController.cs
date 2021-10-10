using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StrikeForce.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StrikeForce.Controllers
{
  public class SalesTeamMembersController: Controller
  {
    private readonly StrikeForceContext _db;
    public SalesTeamMembersController(StrikeForceContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<SalesTeamMember> model = _db.SalesTeamMembers.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(SalesTeamMember salesTeamMember)
    {
      _db.SalesTeamMembers.Add(salesTeamMember);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
} 