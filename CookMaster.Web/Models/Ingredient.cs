using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ingredient : Entity
{
    [Required]
    public IngredientCategorys Category {get; set;}
    public string? ImageURL {get; set;}
    [Required]
    public MeasurementUnit Unit {get; set;}
    public float CaloriesPer100g {get; set;}
    public float ProtienPer100g {get; set;}
    public float CarbsPer100g {get; set;}
    public float FatPer100g {get; set;}
    [Required]
    public float AvgCostPerUnit {get; set;}
    public Ingredient(
        string aName,
        IngredientCategorys aCategory,
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
        Category = aCategory;
        ImageURL = aImageURL;
        Unit = aUnit;
        CaloriesPer100g = aCaloriesPer100g;
        ProtienPer100g = aProtienPer100g;
        CarbsPer100g = aCarbsPer100gm;
        FatPer100g = aFatPer100g;
        AvgCostPerUnit = aAvgCostPerUnit;
    }
    public Ingredient() {}
}