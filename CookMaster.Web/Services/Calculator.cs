namespace ReviewPrototype.Services
{
    public class Calculator
    {
        public static float TotalCost(List<Recipe_Ingredient> Recipe_Ingredients)
        {
            float total = 0;
            foreach (Recipe_Ingredient recipe_Ingredient in recipe_Ingredient)
            {
                total = total + recipe_Ingredient.CostPerRecipe;
            }
            return total;
        }
        public static float? AvgIngredientReview(List<IngredientReview> reviews)
        {
            if (reviews == null || reviews.Count == 0)
            {
                return 0;
            }
            float? rating = 0;
            float? avgRating;
            foreach (IngredientReview review in reviews)
            {
                rating = rating + ((int)review.Rating);
            }
            avgRating = rating / reviews.Count;
            return avgRating;
        }
    }
}