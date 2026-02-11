using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RecipeStep : TimeAudit
{
    public RecipeStep() {}
    [Required]
    [ForeignKey("RecipeID")]
    public int RecipeID {get; set;}
    [Required]
    public int StepNumber {get; set;}
    [Required]
    [StringLength (1000)]
    public string Instructions {get; set;}
    public string? ImageURL {get; set;}
    [Required]
    public int AvgPrepTimeMins {get; set;}
    [Required]
    public int AvgCookTimeMins {get; set;}
    [StringLength (1000)]
    public string Equipment {get; set;}
    [Required]
    public bool OptionalStep {get; set;}
    [StringLength (1000)]
    public string Tip {get; set;}
    public RecipeStep(
        int aStepNumber,
        string aInstructions,
        string aImageURL,
        int aAvgPrepTimeMins,
        int aAvgCookTimeMins,
        string aEquipment,
        bool aOptionalStep,
        string aTip
        )
    {
        StepNumber = aStepNumber;
        Instructions = aInstructions;
        ImageURL = aImageURL;
        AvgPrepTimeMins = aAvgPrepTimeMins;
        AvgCookTimeMins = aAvgCookTimeMins;
        Equipment = aEquipment;
        OptionalStep = aOptionalStep;
        Tip = aTip;
    }
}