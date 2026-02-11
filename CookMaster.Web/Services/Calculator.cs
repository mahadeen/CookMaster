namespace ReviewPrototype.Services
{
    public class Calculator
    {
        public static float TotalCost(List<RecipeIngredient> recipeIngredients)
        {
            float total = 0;
            foreach (RecipeIngredient recipeIngredient in recipeIngredients)
            {
                total = total + recipeIngredient.CostPerRecipe;
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