using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RestroFlowAPI.Data
{
  public class RestroFlowAuthDbContext : IdentityDbContext
  {
    private readonly UserManager<IdentityUser> _userManager;

    public RestroFlowAuthDbContext(DbContextOptions<RestroFlowAuthDbContext> options, UserManager<IdentityUser> userManager) : base(options) {
      _userManager = userManager;
    }

    private async List<IdentityUser> UserSeed() {
      string[] userIds = ["21804e79-b2bb-4a6e-9418-3cab51e579ac", "f2ba15e2-f1d3-43d1-bb84-6767253ebbe2", "9125374f-e121-40f2-b42f-089529dd5fbd", "36c8f410-61d4-49fb-beb0-ff35e319614e", "25a8ee82-6527-4c92-b374-afa6a65cb3b9", "55bc7fd2-de9a-4a8b-9bb8-5d384b8e8f23"];
      string[] userName = ["brian-admin@example.com", "alice-owner@example.com", "bob-manager@example.com", "charlie-manager@example.com", "melissa-staff@example.com", "thomas-staff@example.com"];

      var users = new List<IdentityUser>();

      // add users
      for (int i = 0; i < userIds.Length; i++) {
        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
        users.Add(new() {
          Id = userIds[i],
          UserName = userName[i],
          Email = userName[i],
        });
      }

      // Create user with password
      foreach (var user in users) {
        await _userManager.CreateAsync(user, "Abc123!");
      }
      // seed again


      // find users and add role to it

      return users;
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

      // Seed Roles
      builder.Entity<IdentityRole>().HasData(roles);

      // Seed Users
      builder.Entity<IdentityUser>().HasData(UserSeed());

      // Set Roles to Users
      var UserRoleList = new List<IdentityUserRole<string>>() {
        new (){
          RoleId = "7548f645-d440-4f78-a9f7-5c550018507d", // admin
          UserId = "21804e79-b2bb-4a6e-9418-3cab51e579ac" // Brian-admin
        },
        new() {
          RoleId = "12a30017-f331-45e6-8944-74f1ee52d686", // owner
          UserId = "f2ba15e2-f1d3-43d1-bb84-6767253ebbe2" // alice-owner
        },
        new() {
          UserId = "9125374f-e121-40f2-b42f-089529dd5fbd", // bob-manager
          RoleId = "5f47664-7802-49d9-ba29-f9f30f6d31fa" // manager
        },
        new() {
          UserId = "36c8f410-61d4-49fb-beb0-ff35e319614e" ,// charlie-manager
          RoleId = "5f47664-7802-49d9-ba29-f9f30f6d31fa" // manager
        },
        new() {
          UserId = "25a8ee82-6527-4c92-b374-afa6a65cb3b9" ,// Melissa-staff
          RoleId = "aa60f3e2-a997-4bc9-b16f-1617f950bc88" // staff
        },
        new() {
          UserId = "55bc7fd2-de9a-4a8b-9bb8-5d384b8e8f23", // thomas-staff
          RoleId = "aa60f3e2-a997-4bc9-b16f-1617f950bc88" // staff
        },
      };
      builder.Entity<IdentityUserRole<string>>().HasData(UserRoleList);


    }

  }
}
