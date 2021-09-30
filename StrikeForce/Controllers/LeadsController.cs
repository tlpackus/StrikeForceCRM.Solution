using Microsoft.AspNetCore.Mvc;
using StrikeForce.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace StrikeForce.Controllers
{
  [Authorize]
  public class LeadsController : Controller
  {
    private readonly StrikeForceContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public LeadsController(UserManager<ApplicationUser> userManager, StrikeForceContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userLeads = _db.Leads.Where(entry => entry.User.Id == currentUser.Id).ToList();
      return View(userLeads);
    }
    public ActionResult Create()
    {
      ViewBag.SalesTeamMemberId = new SelectList(_db.SalesTeamMembers, "SalesTeamMemberId", "Name");
      return View();
    }
    [HttpPost]
    public async Task<ActionResult> Create(Lead lead, int SalesTeamMemberId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      lead.User = currentUser;
      _db.Leads.Add(lead);
      _db.SaveChanges();
      if (SalesTeamMemberId != 0)
      {
          _db.LeadSalesTeamMember.Add(new LeadSalesTeamMember() { SalesTeamMemberId = SalesTeamMemberId, LeadId = lead.LeadId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisLead = _db.Leads
        .Include(lead => lead.JoinEntities)
        .ThenInclude(join => join.SalesTeamMember)
        .FirstOrDefault(lead => lead.LeadId == id);
      return View(thisLead);
    }
    public ActionResult Edit(int id)
    {
      var thisLead = _db.Leads.FirstOrDefault(lead => lead.LeadId == id);
      ViewBag.SalesTeamMemberId = new SelectList(_db.SalesTeamMembers, "SalesTeamMemberId", "FirstName");
      return View(thisLead);
    }
    [HttpPost]
    public ActionResult Edit(Lead lead, int SalesTeamMemberId)
    {
      if (SalesTeamMemberId != 0)
      {
        _db.LeadSalesTeamMember.Add(new LeadSalesTeamMember() { SalesTeamMemberId = SalesTeamMemberId, LeadId = lead.LeadId});
      }
      _db.Entry(lead).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
} 