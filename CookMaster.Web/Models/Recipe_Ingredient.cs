using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recipe_Ingredient : Identity
{
    public Recipe_Ingredient() {}
    [Required]
    public int Quantity {get; set;}
    [Required]
    public MeasurementUnit Unit {get; set;}
    [Required]
    public bool IsOptional {get; set;}
    public string Substitutions {get; set;}
    [StringLength(1000)]
    public string Notes {get; set;}
    [Required]
    public int StepID {get; set;}
    public int CostPerRecipe {get; set;}
    // Navigation properties
    [Required]
    [ForeignKey("RecipeID")]
    public int RecipeID {get; set;}
    public Recipe Recipe {get; set;}
    [Required]
    [ForeignKey("IngredientID")]
    public int IngredientID {get; set;}
    // Navigation properties
    public Ingredient Ingredient {get; set;}
    public Recipe_Ingredient(
        int aQuantity,
        MeasurementUnit aUnit,
        bool aIsOptional,
        string aSubstitutions,
        string aNotes,
        int aCostPerRecipe
        )
    {
        Quantity = aQuantity;
        Unit = aUnit;
        IsOptional = aIsOptional;
        Substitutions = aSubstitutions;
        Notes = aNotes;
        CostPerRecipe = aCostPerRecipe;
    }
}