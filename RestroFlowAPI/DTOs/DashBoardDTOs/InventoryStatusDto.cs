namespace RestroFlowAPI.DTOs.DashBoardDTOs
{

  public enum StockLevels
  {
    InStock,
    OutOfStock,
    LowStock
  }
  public class InventoryStatusDto
  {
    public required Guid ItemId { get; set; }
    public required float Quantity { get; set; }
    public required string Unit { get; set; }
    public required StockLevels StockLevel { get; set; }

  }
}
