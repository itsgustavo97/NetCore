using Application;
using Infrastructure;
using Infrastructure.Persistencia;
using Microsoft.EntityFrameworkCore;
using Security;
using Security.Persistencia;
using WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.InjectService(builder.Configuration); //Infrastructure
builder.Services.InjectServiceApp(); //Application
builder.Services.InjectServiceSecurity(builder.Configuration); //Security
builder.Services.AddCors(c => 
{ 
	c.AddPolicy("politica", x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("politica");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
		var loggerFactory = services.GetRequiredService<ILoggerFactory>();
		try
		{
			var context = services.GetRequiredService<ApplicationDBContext>();
			await context.Database.MigrateAsync();

            //var SecurityContext = services.GetRequiredService<SecurityDBContext>();
            //await context.Database.MigrateAsync();
        }
		catch (Exception ex)
		{
			var logger = loggerFactory.CreateLogger<Program>();
			logger.LogError("Ocurrió un error: ",ex);
		}
    }
}

app.Run();
