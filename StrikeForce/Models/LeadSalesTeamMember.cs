namespace StrikeForce.Models
{
  public class LeadSalesTeamMember
  {
    public int LeadSalesTeamMemberId { get; set; }
    public int LeadId { get; set; }
    public int SalesTeamMemberId { get; set; }
    public virtual Lead Lead { get; set; }
    public virtual SalesTeamMember SalesTeamMember { get; set; }
  }
} 