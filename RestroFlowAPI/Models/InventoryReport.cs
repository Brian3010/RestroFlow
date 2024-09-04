using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class InventoryReport
  {
    public Guid Id { get; set; } // Primary Key
    public string ReportSubject { get; set; }
    public string ReportDescription { get; set; }
    public DateTime CreatedAt { get; set; }


    // Foreign Keys
    public Guid RestaurantId { get; set; }
    public required string UserId { get; set; }

    // Navigation Properties
    public Restaurant Restaurant { get; set; }

    [ForeignKey("UserId")]
    public IdentityUser User { get; set; }
  }
}
