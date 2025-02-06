var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", 
        builder => builder
            .WithOrigins("http://localhost:4200") // Set the Angular app URL here
            .AllowAnyHeader() // Allow any headers
            .AllowAnyMethod()); // Allow any HTTP methods
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseCors("AllowAngularApp"); 

app.UseHttpsRedirection(); 

app.MapControllers();

app.Run(); 