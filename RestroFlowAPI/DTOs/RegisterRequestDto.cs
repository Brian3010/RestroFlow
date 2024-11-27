﻿using System.ComponentModel.DataAnnotations;

namespace RestroFlowAPI.Models.DTOs
{
  public class RegisterRequestDto
  {
    [Required]
    [DataType(DataType.EmailAddress)]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    [Required]
    public string[] Roles { get; set; }
  }
}
