using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{
  public class AlertRecipient
  {
    public Guid AlertRecipientId { get; set; } // Primary Key


    // Foreign Keys
    public Guid InventoryAlertId { get; set; }
    public required string RecipientId { get; set; }

    // Navigation Properties
    [ForeignKey("RecipientId")]
    public required IdentityUser User { get; set; } // RecipientId
    public required InventoryAlert InventoryAlert { get; set; }

  }
}
