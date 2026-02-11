using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Index(nameof(DishName), IsUnique=true)]
public class Dish : Entity
{
    public Dish() {}
    [StringLength(1000)]
    public string Description {get; set;}
    [Required]
    public Cuisines Cuisine {get; set;}
    [Required]
    public CourseTypes CourseType {get; set;}
    [Required]
    public DifficultyLevels DifficultyLevel {get; set;}
    public string ImageURL {get; set;}
    public int AvgPrepTimeMins {get; set;}
    public int AvgCookTimeMins {get; set;}
    public int CreatedByUserID {get; set;}
    public Statuses Status {get; set;}
    public bool IsVerified {get; set;}
    public List<Recipe> Recipes {get; set;} = new();

    public Dish(
        string aName,
        string aDescription,
        Cuisines aCuisine,
        CourseTypes aCourseType,
        DifficultyLevels aDifficultyLevel,
        string aImageURL,
        int aAvgPrepTimeMins,
        int aAvgCookTimeMins,
        int aCreatedByUserID,
        Statuses aStatus,
        bool aIsVerified,
        DateTime aCreatedAt,
        DateTime aUpdatedAt
        )
    {
        Name = aName;
        Description = aDescription;
        Cuisine = aCuisine;
        CourseType = aCourseType;
        DifficultyLevel = aDifficultyLevel;
        ImageURL = aImageURL;
        AvgPrepTimeMins = aAvgPrepTimeMins;
        AvgCookTimeMins = aAvgCookTimeMins;
        CreatedByUserID = aCreatedByUserID;
        Status = aStatus;
        IsVerified = aIsVerified;
        CreatedAt = aCreatedAt;
        UpdatedAt = aUpdatedAt;
    }
}
