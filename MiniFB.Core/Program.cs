using MiniFB.Core.Services;
using MiniFB.Core.Db;
// DONE Populate Context
// TODO Write Services (Repository)
// TODO Inject Services (Dependency Injection)


// Add services to the builder.
var builder = WebApplication.CreateBuilder(args);
{   
    builder.Services.AddControllers(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddDbContext<MiniFbContext>();
    builder.Services.AddScoped<IStatusService, StatusService>();
}

// HTTP request pipeline
var app = builder.Build();
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}