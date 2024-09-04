using Microsoft.AspNetCore.Identity;

namespace RestroFlowAPI.Models
{
  public class AlertRecipient
  {
    public Guid AlertRecipientId { get; set; } // Primary Key


    // Foreign Keys
    public Guid InventoryAlertId { get; set; }
    public Guid RecipientId { get; set; }

    // Navigation Properties
    public required IdentityUser User { get; set; } // RecipientId
    public required InventoryAlert InventoryAlert { get; set; }

  }
}
