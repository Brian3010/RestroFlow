using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RestroFlowAPI.Data
{
  public class RestroFlowAuthDbContext : IdentityDbContext
  {
    private readonly UserManager<IdentityUser> _userManager;

    // Seed data for Roles
    private string adminRoleId = "7548f645-d440-4f78-a9f7-5c550018507d";
    private string ownerRoleId = "12a30017-f331-45e6-8944-74f1ee52d686";
    private string staffRoleId = "aa60f3e2-a997-4bc9-b16f-1617f950bc88";
    private string managerRoleId = "5f47664-7802-49d9-ba29-f9f30f6d31fa";

    public RestroFlowAuthDbContext(DbContextOptions<RestroFlowAuthDbContext> options, UserManager<IdentityUser> userManager) : base(options) {
      _userManager = userManager;
    }

    private async List<IdentityUser> UserSeedAsync() {
      string[] userIds = ["21804e79-b2bb-4a6e-9418-3cab51e579ac", "f2ba15e2-f1d3-43d1-bb84-6767253ebbe2", "9125374f-e121-40f2-b42f-089529dd5fbd", "36c8f410-61d4-49fb-beb0-ff35e319614e", "25a8ee82-6527-4c92-b374-afa6a65cb3b9", "55bc7fd2-de9a-4a8b-9bb8-5d384b8e8f23"];
      string[] userName = ["brian-admin@example.com", "alice-owner@example.com", "bob-manager@example.com", "charlie-manager@example.com", "melissa-staff@example.com", "thomas-staff@example.com"];

      var users = new List<IdentityUser>();

      for (int i = 0; i < userIds.Length; i++) {
        users.Add(new() {
          Id = userIds[i],
          UserName = userName[i],
          Email = userName[i],

        });

      }
      foreach (var user in users) {
        await _userManager.CreateAsync(user, "Abc123!");
        var foundUser = await _userManager.FindByNameAsync(user.UserName!);

      }
      // find users and add role to it




      return users;
    }

    protected override void OnModelCreating(ModelBuilder builder) {
      base.OnModelCreating(builder);



      var roles = new List<IdentityRole> {
        new () {Id=adminRoleId,Name= "Admin",ConcurrencyStamp = adminRoleId,NormalizedName= "Admin".ToUpper()},
        new (){Id=ownerRoleId,Name= "Owner",ConcurrencyStamp = ownerRoleId,NormalizedName= "Owner".ToUpper()},
        new (){Id=staffRoleId,Name= "Staff",ConcurrencyStamp = staffRoleId,NormalizedName= "Staff".ToUpper()},
        new (){Id=managerRoleId,Name= "Manager",ConcurrencyStamp = managerRoleId,NormalizedName= "Manager".ToUpper()},

      };

      // Seed Data for users

      //builder.Entity<IdentityRole>().HasData(...);

      builder.Entity<IdentityRole>().HasData(roles);


    }

  }
}
