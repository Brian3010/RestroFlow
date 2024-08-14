using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RestroFlowAPI.Data
{
  public class RestroFlowAuthDbContext : IdentityDbContext
  {
    public RestroFlowAuthDbContext(DbContextOptions<RestroFlowAuthDbContext> options) : base(options) {

    }

    protected override void OnModelCreating(ModelBuilder builder) {
      base.OnModelCreating(builder);

      // Seed data for Roles
      var adminRoleId = "7548f645-d440-4f78-a9f7-5c550018507d";
      var ownerRoleId = "12a30017-f331-45e6-8944-74f1ee52d686";
      var staffRoleId = "aa60f3e2-a997-4bc9-b16f-1617f950bc88";
      var managerRoleId = "5f47664-7802-49d9-ba29-f9f30f6d31fa";

      var roles = new List<IdentityRole> {
        new () {Id=adminRoleId,Name= "Admin",ConcurrencyStamp = adminRoleId,NormalizedName= "Admin".ToUpper()},
        new (){Id=ownerRoleId,Name= "Owner",ConcurrencyStamp = ownerRoleId,NormalizedName= "Owner".ToUpper()},
        new (){Id=staffRoleId,Name= "Staff",ConcurrencyStamp = staffRoleId,NormalizedName= "Staff".ToUpper()},
        new (){Id=managerRoleId,Name= "Manager",ConcurrencyStamp = managerRoleId,NormalizedName= "Manager".ToUpper()},

      };

      builder.Entity<IdentityRole>().HasData(roles);


    }

  }
}
