using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StrikeForce.Models
{
  public class StrikeForceContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Lead> Leads { get; set; }
    public DbSet<SalesTeamMember> SalesTeamMembers { get; set; }
    public DbSet<LeadSalesTeamMember> LeadSalesTeamMember { get; set; }

    public StrikeForceContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
} 