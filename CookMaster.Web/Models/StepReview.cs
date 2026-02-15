using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StepReview : TimeAudit
{
    public StepReview() {}
    public int? AttemptNumber {get; set;}
    [Required]
    public Ratings Rating {get; set;}
    [StringLength(1000)]
    public string ReviewBody {get; set;}
    public int ActualTimeMinutes {get; set;}
    [StringLength(1000)]
    public string? Notes {get; set;}
    [Required]
    public DifficultyLevels? DifficultyLevel {get; set;}
    [StringLength(1000)]
    public string? ImprovementSuggestions {get; set;}
    public string? ImageURL {get; set;}
    public bool? Success {get; set;}
    // Foreign Keys
    [Required]
    public int RecipStepID {get; set;}
    [Required]
    public int RecipeID {get; set;}
    // Navigation properties
    public RecipeStep RecipeStep {get; set;}

    public StepReview(
        int aAttemptNumber,
        Ratings aRating,
        string aReviewBody,
        int aActualTimeMinutes,
        string aNotes,
        DifficultyLevels aDifficultyLevel,
        string aImprovementSuggestions,
        string aImageURL,
        bool aSuccess
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
    }
}