var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ToDoWebApi.Services.ITodoService, ToDoWebApi.Services.TodoService>();
builder.Services.AddControllers();

// Add Swagger services
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "ToDo Web API",
        Version = "v1",
        Description = "A simple ToDo API built with ASP.NET Core",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "ToDo API Team"
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToDo Web API v1");
        c.RoutePrefix = string.Empty; // Makes Swagger UI available at root URL
    });
}

// Remove HTTPS redirection for Docker container
// app.UseHttpsRedirection();

app.MapControllers();
app.Run();

