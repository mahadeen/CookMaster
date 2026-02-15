using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Inventory : Identity
{
    public Inventory() {}

    [Required]
    public float Quantity {get; set;}
    [Required]
    public MeasurementUnit Unit {get; set;}
    [Required]
    public DateTime? PurchaseDate {get; set;}
    [Required]
    public DateTime? ExpirationDate {get; set;}
    [Required]
    public float? Cost {get; set;}
    [StringLength(1000)]
    public string? Notes {get; set;}
    // Foreign Keys
    [Required]
    public int IngredientID {get; set;}
    // Navigation properties
    public Ingredient Ingredient {get; set;}

    public Inventory(
        int aIngredientID,
        float aQuantity,
        MeasurementUnit aUnit,
        DateTime aPurchaseDate,
        DateTime aExpirationDate,
        float aCost,
        string aNotes
        )
    {
        IngredientID = aIngredientID;
        Quantity = aQuantity;
        Unit = aUnit;
        PurchaseDate = aPurchaseDate;
        ExpirationDate = aExpirationDate;
        Cost = aCost;
        Notes = aNotes;
    }
}