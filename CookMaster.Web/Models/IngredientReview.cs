using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class IngredientReview
{
    public IngredientReview() {}
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID {get; set;}
    [Required]
    [ForeignKey("IngredientID")]
    public int IngredientID {get; set;}
    [Required]
    [ForeignKey("RecipeID")]
    public int RecipeID {get; set;}
    [Required]
    [ForeignKey("RecipStepID")]
    public int RecipStepID {get; set;}
    [Required]
    public Ratings Rating {get; set;}
    [StringLength(1000)]
    public string ReviewBody {get; set;}
    public int ActualTimeMinutes {get; set;}
    [StringLength(1000)]
    public string Notes {get; set;}
    public string ImprovementSuggestions {get; set;}
    [StringLength(1000)]
    public string ImageURL {get; set;}
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public DateTime CreatedAt {get; set;}
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [Required]
    public DateTime UpdatedAt {get; set;}
    public IngredientReview(
        Ratings aRating,
        string aReviewBody,
        int aActualTimeMinutes,
        string aNotes,
        string aImprovementSuggestions,
        string aImageURL,
        DateTime aCreatedAt,
        DateTime aUpdatedAt
        )
    {
        Rating = aRating;
        ReviewBody = aReviewBody;
        ActualTimeMinutes = aActualTimeMinutes;
        Notes = aNotes;
        ImprovementSuggestions = aImprovementSuggestions;
        ImageURL = aImageURL;
        CreatedAt = aCreatedAt;
        UpdatedAt = aUpdatedAt;
    }
}