using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Recipe
{
    public Recipe() {}
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID {get; set;}
    [Required]
    public int DishID {get; set;}
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Title {get; set;}
    [StringLength(1000)]
    public string Description {get; set;}
    [Required]
    [Range(1, 50)]
    public int Servings {get; set;}
    public int AvgPrepTimeMins {get; set;}
    public int AvgCookTimeMins {get; set;}
    [NotMapped]
    public int TotalTime {get {return AvgCookTimeMins + AvgPrepTimeMins;}}
    public DifficultyLevels DifficultyLevel {get; set;}
    public string CoverImageURL {get; set;}
    public Statuses Status {get; set;}
    public string NutritionInfo {get; set;}
    public string Tags {get; set;}
    public float RatingAvg {get; set;}
    public int ReviewCount {get; set;}
    public float TotalCost {get; set;}
    [NotMapped]
    public float CostPerServing {get {return TotalCost / Servings;}}
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public DateTime CreatedAt {get; set;}
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Required]
    public DateTime UpdatedAt {get; set;}
    public Dish Dish {get; set;}
    public Recipe(
        string aTitle,
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
        Title = aTitle;
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