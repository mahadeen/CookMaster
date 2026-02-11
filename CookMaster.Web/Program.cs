using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReviewPrototype.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapGet("/recipes", (context) =>
    {
        var recipes = app.ApplicationServices.GetService<JsonFileProductService>().GetRecipes();
        var json = JsonSerializer.Serialize<IEnumerable<Recipe>>(recipes);
        return context.Response.WriteAsync(json);
    });
});

app.MapStaticAssets();
app.MapControllers();
app.MapRazorPages()
.WithStaticAssets();

app.Run();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.Run();
app.MapPost("/avg-review", (List<IngredientReview> reviews) =>
{
    float? avg = Calculator.AvgIngredientReview(reviews);
    return Results.Ok(new { average = avg });
});

IngredientReview review1 = new IngredientReview(
    aRating: Ratings.Poor,
    aReviewBody: "A bit too salty",
    aActualTimeMinutes: 12,
    aNotes: "should be refrigerated",
    aImprovementSuggestions: "Mix well",
    aImageURL: "https://media.istockphoto.com/id/1214887475/photo/salt-glass-salt",
    aCreatedAt: DateTime.Now,
    aUpdatedAt: DateTime.Now
    );