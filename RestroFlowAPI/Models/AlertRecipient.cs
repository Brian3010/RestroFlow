namespace RestroFlowAPI.Models
{
  public class AlertRecipient
  {
    public Guid AlertRecipientId { get; set; } // Primary Key


    // Foreign Keys
    //public Guid InventoryAlertId { get; set; }

    // Foreign Key for UserId from RestroFlowAuthDbContext
    // No navigation property since it belongs to another DbContext
    public required Guid RecipientId { get; set; }

  }
}
