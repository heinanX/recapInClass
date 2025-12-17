using recap1217.Core.Interfaces;
using recap1217.Core.Services;
using recap1217.Data.Interfaces;
using recap1217.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


// this is the automapper registration which means we can use automapper in our project. its a service that can be injected where needed
builder.Services.AddAutoMapper(typeof(Program));

//this is the generator that creates swagger documentation for our API
builder.Services.AddSwaggerGen(options =>

// this is the configuration for swagger to use Bearer token authentication, 
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Name = "Authentication",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Enter 'Bearer' <token>"
    })
);

// Here is the DI container setup. The DI container will resolve the dependencies for IUserService and IUserRepo
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();


var app = builder.Build();


//Here we add Swagger UI which is a web interface to interact with our API documentation
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
