using System.ComponentModel.DataAnnotations;

namespace RestroFlowAPI.DTOs
{
  public class RFTokenRequestDto
  {
    [Required]
    public string? userId { get; set; }
  }
}
