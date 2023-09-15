using MediatR_Basic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR_Basic.Services.MediatR;
using Notifier1 = MediatR_Basic.Services.Notifier1;
using Notifier2 = MediatR_Basic.Services.Notifier2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddTransient<INotifier, Notifier1>();
builder.Services.AddTransient<INotifier, Notifier2>();

builder.Services.AddTransient<INotifierMediatorService, NotifierMediatorService>();

builder.Services.AddTransient<INotifierMediatRService, NotifierMediatRService>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

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
