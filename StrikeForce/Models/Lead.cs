using System.Collections.Generic;
using System;

namespace StrikeForce.Models
{
  public class Lead
  {
    public Lead()
    {
      this.JoinEntities = new HashSet<LeadSalesTeamMember>();
    }
    public int LeadId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }
    public string LeadType { get; set; }
    public string DateInfoAcquired { get; set; }
    public string Notes { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<LeadSalesTeamMember> JoinEntities { get; }
  }
}
