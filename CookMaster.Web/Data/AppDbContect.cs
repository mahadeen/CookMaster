public class AppDbContext : DbContext
{
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<IngredientReview> IngredientReviews { get; set; }
    public DbSet<Dish> Dishes {get; set;}
    public DbSet<Inventory> Inventories {get; set;}
    public DbSet<RecipeIngredient> RecipeIngredients {get; set;}
    public DbSet<RecipeStep> RecipeSteps {get; set;}
    public DbSet<StepReview> StepReviews {get; set;}


    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent configuration goes here
        base.OnModelCreating(modelBuilder);
    }
}