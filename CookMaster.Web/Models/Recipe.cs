using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Recipe : Entity
{
    public Recipe() {}
    [StringLength(1000)]
    public string Description {get; set;}
    [Required]
    [Range(1, 50)]
    public int Servings {get; set;}
    public int? AvgPrepTimeMins {get; set;}
    public int? AvgCookTimeMins {get; set;}
    [NotMapped]
    public int TotalTime {get {return AvgCookTimeMins + AvgPrepTimeMins;}}
    public DifficultyLevels? DifficultyLevel {get; set;}
    public string? CoverImageURL {get; set;}
    public Statuses? Status {get; set;}
    public string? NutritionInfo {get; set;}
    public string? Tags {get; set;}
    public float RatingAvg {get; set;}
    public int ReviewCount {get; set;}
    public float? TotalCost {get; set;}
    [NotMapped]
    public float CostPerServing {get {return TotalCost / Servings;}}
    // Foreign Keys
    [Required]
    public int DishID {get; set;}
    // Navigation properties
    public Dish Dish {get; set;}
    public List<Recipe_Ingredient> Recipe_Ingredients {get; set;} = new();
    public List<RecipeStep> RecipeSteps {get; set;} = new();


    public Recipe(
        string aName,
        string aDescription,
        int aServings,
        int aAvgPrepTimeMins,
        int aAvgCookTimeMins,
        DifficultyLevels aDifficultyLevel,
        string aCoverImageURL,
        Statuses aStatus,
        string aNutritionInfo,
        string aTags,
        float aRatingAvg,
        int aReviewCount,
        float aTotalCost
        )
    {
        Name = aName;
        Description = aDescription;
        Servings = aServings;
        AvgPrepTimeMins = aAvgPrepTimeMins;
        AvgCookTimeMins = aAvgCookTimeMins;
        DifficultyLevel = aDifficultyLevel;
        CoverImageURL = aCoverImageURL;
        Status = aStatus;
        NutritionInfo = aNutritionInfo;
        Tags = aTags;
        RatingAvg = aRatingAvg;
        ReviewCount = aReviewCount;
        TotalCost = aTotalCost;
    }
}