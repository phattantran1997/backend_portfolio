using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 32))));

builder.Services.AddScoped<IExperienceService,ExperirenceService>();
builder.Services.AddScoped<IExperienceRepository,ExperienceRepository>();
builder.Services.AddScoped<IPublicationRepository,PublicationRepository>();
builder.Services.AddScoped<IPublicationService,PublicationService>();
builder.Services.AddScoped<IBlogService,BlogService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                            policy.WithOrigins("http://localhost:5173")
            .SetIsOriginAllowedToAllowWildcardSubdomains();
                      });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
