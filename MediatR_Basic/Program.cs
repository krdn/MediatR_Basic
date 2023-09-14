using MediatR_Basic.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddTransient<INotifier, Notifier1>();
builder.Services.AddTransient<INotifier, Notifier2>();

builder.Services.AddTransient<INotifierMediatorService, NotifierMediatorService>();

//builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
