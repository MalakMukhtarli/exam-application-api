using ExamApplication.Api.Filters;
using ExamApplication.Business.Extensions;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

var config = builder.Configuration;
services.InstallServicesInAssembly(config);

services.AddControllers(options =>
    {
        options.Filters.Add<ExceptionFilter>();
        options.MaxModelBindingCollectionSize = int.MaxValue;
    })
    .AddFluentValidation(x => x.AutomaticValidationEnabled = false);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
