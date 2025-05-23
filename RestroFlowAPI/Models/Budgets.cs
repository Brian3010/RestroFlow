﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestroFlowAPI.Models
{

  public class Budgets
  {

    public Guid Id { get; set; } // Primary Key

    [Column(TypeName = "decimal(18,2)")]
    public decimal BudgetAmount { get; set; }
    public string? Description { get; set; }
    // Weekly period represented by start and end dates
    public DateTime BudgetStartDate { get; set; }  // Start of the week
    public DateTime BudgetEndDate { get; set; }    // End of the week
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }


    // Foreign Key to Restaurants
    public required Guid BudgetCategoryId { get; set; }
    public Guid RestaurantId { get; set; }

    // Navigation Property
    public Restaurants Restaurant { get; set; }
    public BudgetExpenses BudgetExpenses { get; set; }
  }
}
