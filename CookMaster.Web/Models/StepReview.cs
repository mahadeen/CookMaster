using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StepReview
{
    public StepReview() {}
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID {get; set;}
    [Required]
    [ForeignKey("RecipStepID")]
    public int RecipStepID {get; set;}
    [Required]
    [ForeignKey("RecipeID")]
    public int RecipeID {get; set;}
    public int AttemptNumber {get; set;}
    [Required]
    public Ratings Rating {get; set;}
    [StringLength(1000)]
    public string ReviewBody {get; set;}
    public int ActualTimeMinutes {get; set;}
    [StringLength(1000)]
    public string Notes {get; set;}
    [Required]
    public DifficultyLevels DifficultyLevel {get; set;}
    [StringLength(1000)]
    public string ImprovementSuggestions {get; set;}
    public string ImageURL {get; set;}
    public bool Success {get; set;}
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public DateTime CreatedAt {get; set;}
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Required]
    public DateTime UpdatedAt {get; set;}

    public StepReview(
        int aAttemptNumber,
        Ratings aRating,
        string aReviewBody,
        int aActualTimeMinutes,
        string aNotes,
        DifficultyLevels aDifficultyLevel,
        string aImprovementSuggestions,
        string aImageURL,
        bool aSuccess,
        DateTime aCreatedAt,
        DateTime aUpdatedAt
        )
    {
        AttemptNumber = aAttemptNumber;
        Rating = aRating;
        ReviewBody = aReviewBody;
        ActualTimeMinutes = aActualTimeMinutes;
        Notes = aNotes;
        DifficultyLevel = aDifficultyLevel;
        ImprovementSuggestions = aImprovementSuggestions;
        ImageURL = aImageURL;
        Success = aSuccess;
        CreatedAt = aCreatedAt;
        UpdatedAt = aUpdatedAt;
    }
}