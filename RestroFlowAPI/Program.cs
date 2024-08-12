
using RestroFlowAPI.Data;

namespace RestroFlowAPI
{
  public class Program
  {
    public static void Main(string[] args) {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.

      builder.Services.AddControllers();
      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      // DBContext
      builder.Services.AddDbContext<RestroFlowAuthDbContext>(options => builder.Configuration.GetConnectionString("RestroFlowConnectionString"));

      //Authentication and Authorization
      //builder.Services.AddAuthorization;
      //builder.Services.AddAuthentication().AddBearerToken(JwtBearerToken);

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment()) {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseAuthorization();


      app.MapControllers();

      app.Run();
    }
  }
}
