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
        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        UpdateTimestamps();
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateTimestamps();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateTimestamps()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is AuditableEntity &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            var entity = (AuditableEntity)entry.Entity;

            if (entry.State == EntityState.Added)
                entity.CreatedAt = DateTime.UtcNow;

            entity.UpdatedAt = DateTime.UtcNow;
        }
    }
}
