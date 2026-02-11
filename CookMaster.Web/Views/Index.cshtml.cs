using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookMaster.Web.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {

    }
}


public IndexModel(ILogger<IndexModel> logger,
    JsonFileProductService productService)
{
    _logger = logger;
    RecipeService = recipeService;
}

public JsonFileProductService ProductService { get; }
public IEnumerable<Recipe> Recipes { get; private set; }

public void OnGet()
{
    Recipes = RecipeService.GetRecipes();
}