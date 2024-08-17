namespace RestroFlowAPI.Models.DTOs
{
  public class LoginRepponseDto
  {
    public string Message { get; set; }

    public string AccessToken { get; set; }

    public string UserId { get; set; }

    public string UserEmail { get; set; }
    public string UserName { get; set; }

  }
}
