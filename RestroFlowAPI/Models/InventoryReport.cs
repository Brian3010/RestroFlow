using Microsoft.AspNetCore.Identity;

namespace RestroFlowAPI.Models
{
  public class InventoryReport
  {
    public Guid ReportId { get; set; } // Primary Key
    public string ReportSubject { get; set; }
    public string ReportDescription { get; set; }
    public DateTime CreatedAt { get; set; }


    // Foreign Keys
    public Guid RestaurantId { get; set; }
    public Guid UserId { get; set; }

    // Navigation Properties
    public Restaurant Restaurant { get; set; }
    public IdentityUser User { get; set; }
  }
}
