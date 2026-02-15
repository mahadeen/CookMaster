using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class IngredientReview : TimeAudit
{
    public IngredientReview() {}
    public Ratings? Rating {get; set;}
    [StringLength(1000)]
    public string ReviewBody {get; set;}
    public int? ActualTimeMinutes {get; set;}
    [StringLength(1000)]
    public string? Notes {get; set;}
    [StringLength(1000)]
    public string? ImprovementSuggestions {get; set;}
    public string? ImageURL {get; set;}
    // Foreign Keys
    [Required]
    public int IngredientID {get; set;}
    [Required]
    public int RecipeID {get; set;}
    [Required]
    public int RecipStepID {get; set;}
    [Required]
    // Navigation properties
    public Ingredient Ingredient {get; set;}
    public IngredientReview(
        Ratings aRating,
        string aReviewBody,
        int aActualTimeMinutes,
        string aNotes,
        string aImprovementSuggestions,
        string aImageURL
        )
    {
        Rating = aRating;
        ReviewBody = aReviewBody;
        ActualTimeMinutes = aActualTimeMinutes;
        Notes = aNotes;
        ImprovementSuggestions = aImprovementSuggestions;
        ImageURL = aImageURL;
    }
}