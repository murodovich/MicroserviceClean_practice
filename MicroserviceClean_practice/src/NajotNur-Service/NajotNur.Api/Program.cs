using Microsoft.EntityFrameworkCore;
using NajotNur.Application.Data;
using NajotNur.Application.Repositories.UserRepositories;
using NajotNur.Infrastructure.Services.UserServices;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<NajotNurDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();

app.MapControllers();

app.Run();
