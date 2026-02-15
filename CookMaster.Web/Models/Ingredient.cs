using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Ingredient : Entity
{
    public Ingredient() {}
    [Required]
    public IngredientCategorys IngredientCategory {get; set;}
    [Required]
    public MeasurementUnit Unit {get; set;}
    [Required]
    public float AvgCostPerUnit {get; set;}
    public string? ImageURL {get; set;}
    public float? CaloriesPer100g {get; set;}
    public float? ProtienPer100g {get; set;}
    public float? CarbsPer100g {get; set;}
    public float? FatPer100g {get; set;}

    // Navigation properties
    public List<Recipe_Ingredient> Recipe_Ingredients {get; set;} = new();
    public List<IngredientReview> IngredientReviews {get; set;} = new();
    public List<Inventory> Inventories = new();
    public Ingredient(
        string aName,
        IngredientCategorys aIngredientCategory,
        string aImageURL,
        MeasurementUnit aUnit,
        float aCaloriesPer100g,
        float aProtienPer100g,
        float aCarbsPer100gm,
        float aFatPer100g,
        float aAvgCostPerUnit
        )
    {
        Name = aName;
        IngredientCategorys = aIngredientCategory;
        ImageURL = aImageURL;
        Unit = aUnit;
        CaloriesPer100g = aCaloriesPer100g;
        ProtienPer100g = aProtienPer100g;
        CarbsPer100g = aCarbsPer100gm;
        FatPer100g = aFatPer100g;
        AvgCostPerUnit = aAvgCostPerUnit;
    }
}