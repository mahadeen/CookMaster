using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RecipeIngredient : Identity
{
    public RecipeIngredient() {}
    [Required]
    [ForeignKey("RecipeID")]
    public int RecipeID {get; set;}
    [Required]
    [ForeignKey("IngredientID")]
    public int IngredientID {get; set;}
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
    [ForeignKey("StepID")]
    public int StepID {get; set;}
    public int CostPerRecipe {get; set;}
    public RecipeIngredient(
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