namespace RestroFlowAPI.Models
{

  public class PaymentMethods
  {
    public required Guid Id { get; set; }

    public required string PaymentName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
  }
}
