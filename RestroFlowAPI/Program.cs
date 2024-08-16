using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestroFlowAPI.Data;
using RestroFlowAPI.Interfaces;
using RestroFlowAPI.Middlewares;
using RestroFlowAPI.Services;
using Serilog;

namespace RestroFlowAPI
{
  public class Program
  {
    public static void Main(string[] args) {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.

      // Add Serilog
      var logger = new LoggerConfiguration().WriteTo.Console().MinimumLevel.Information().CreateLogger();
      builder.Logging.ClearProviders();
      builder.Logging.AddSerilog(logger);
      logger.Information("Serilog starting");
      logger.Information($"Total services: {builder.Services.Count}");

      builder.Services.AddControllers();
      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      // Inject DbContexts
      builder.Services.AddDbContext<RestroFlowAuthDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RestroFlowAuthConnectionString")));

      // register DIs
      builder.Services.AddScoped<ITokenService, TokenService>();

      // Add Identity system to the ASP.NET Core service container
      builder.Services.AddIdentityCore<IdentityUser>()
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<RestroFlowAuthDbContext>()
        .AddDefaultTokenProviders();
      builder.Services.Configure<IdentityOptions>(options => {
        options.User.RequireUniqueEmail = true;
        options.Password.RequireDigit = true;
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequireUppercase = true;
        options.Password.RequiredUniqueChars = 1;
        options.Password.RequiredLength = 6;
      });


      //Authentication and Authorization
      builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment()) {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseMiddleware<ExceptionHandlerMiddleware>();

      app.UseHttpsRedirection();

      app.UseAuthentication();
      app.UseAuthorization();


      app.MapControllers();

      app.Run();
    }
  }
}
