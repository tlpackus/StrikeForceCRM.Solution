using System.Collections.Generic;

namespace StrikeForce.Models
{
  public class SalesTeamMember
  {
    public SalesTeamMember()
    {
      this.JoinEntities = new HashSet<LeadSalesTeamMember>();
    }
    public int SalesTeamMemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Notes { get; set; }
    public virtual ICollection<LeadSalesTeamMember> JoinEntities { get; set; }
  }
} 