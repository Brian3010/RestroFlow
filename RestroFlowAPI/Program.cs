using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RestroFlowAPI.Data;
using RestroFlowAPI.Interfaces;
using RestroFlowAPI.Middlewares;
using RestroFlowAPI.OptionsSetup;
using RestroFlowAPI.Services;
using Serilog;
using StackExchange.Redis;

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
      builder.Services.AddSwaggerGen(options => {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "RestroFlow APIs", Version = "V1" });
        options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme {
          Name = "Authorization",
          Description = "Enter 'Bearer' following by space and JWT.",
          In = ParameterLocation.Header,
          Type = SecuritySchemeType.ApiKey,
          Scheme = "bearer",
        });
        options.AddSecurityRequirement(new OpenApiSecurityRequirement {
          {
            new OpenApiSecurityScheme {
              Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = JwtBearerDefaults.AuthenticationScheme },
              Scheme ="Oauth2",
              Name = JwtBearerDefaults.AuthenticationScheme,
              In = ParameterLocation.Header
            },
             new List<string>()
          }
        });
      });

      // Inject DbContexts
      builder.Services.AddDbContext<RestroFlowAuthDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RestroFlowAuthConnectionString")));

      // Add Redis connection
      builder.Services.AddSingleton<IConnectionMultiplexer>(sp => {
        var configuration = builder.Configuration.GetConnectionString("RedisConnectionString")!;
        return ConnectionMultiplexer.Connect(configuration);
      });
      //builder.Services.AddStackExchangeRedisCache(redisOptions => {
      //  redisOptions.Configuration = builder.Configuration.GetConnectionString("RedisConnectionString");
      //});

      // register DIs
      builder.Services.AddScoped<ITokenService, TokenService>();
      builder.Services.AddScoped<ICustomCookieManager, CookiesManager>();
      builder.Services.AddScoped<IRedisTokenService, RedisTokenService>();

      // Add Identity system to the ASP.NET Core service container
      builder.Services.AddIdentityCore<IdentityUser>()
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<RestroFlowAuthDbContext>()
        .AddDefaultTokenProviders();
      builder.Services.Configure<IdentityOptions>(options => {
        options.User.RequireUniqueEmail = true;
        options.Password.RequiredLength = 6;
      });


      //Authentication and Authorization
      /*
      builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters {
          ValidateIssuer = true,
          ValidateAudience = true,
          ValidateLifetime = true,
          ValidateIssuerSigningKey = true,
          ValidIssuer = builder.Configuration["Jwt:Issuer"],
          ValidAudience = builder.Configuration["Jwt:Audience"],
          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SigningKey"]))
        };
      });
      */

      builder.Services.ConfigureOptions<JwtBearerTokenOptions>().AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

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
