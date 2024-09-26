using System.ComponentModel.DataAnnotations;

namespace RestroFlowAPI.DTOs.DashBoardDTOs
{
  public class PeriodRequestDto<T>
  {
    [Required]
    public T? Period { get; set; }
  }
}
