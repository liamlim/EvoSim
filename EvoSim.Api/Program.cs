using EvoSim.Core;
using EvoSim.Db.Extensions;

using Microsoft.AspNetCore.Mvc;

[assembly: ApiController]

var builder = WebApplication.CreateBuilder(args);

const string swaggerDocName = "evosim";

builder.Services
    .AddDbServices()
    .AddCoreServices()
    .AddSwaggerGen(swaggerGenOptions =>
    {
        swaggerGenOptions.SwaggerDoc(swaggerDocName, new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Title = "Evo Sim API",
            Version = "0.0.1"
        });
    })
    .AddControllers(mvcOptions =>
    {
        mvcOptions.EnableEndpointRouting = false;
    });

var application = builder.Build();

application
    .UseMvc()
    .UseSwagger()
    .UseSwaggerUI(swaggerUIOptions =>
    {
        swaggerUIOptions.SwaggerEndpoint($"/swagger/{swaggerDocName}/swagger.json", swaggerDocName);
        swaggerUIOptions.RoutePrefix = string.Empty;
    });

application.Run();
