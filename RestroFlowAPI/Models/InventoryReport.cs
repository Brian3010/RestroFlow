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

    // Foreign Key for UserId from RestroFlowAuthDbContext
    // No navigation property since it belongs to another DbContext
    public required string UserId { get; set; }

    // Navigation Properties
    public Restaurant Restaurant { get; set; }


  }
}
