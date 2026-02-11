public enum Cuisines
{
    American,
    Arabic,
    Asian,
    BBQ,
    Beef,
    Breakfast,
    Burger,
    Burritos,
    Chicken,
    Chinese,
    Dessert,
    European,
    FriedChicken,
    Healthy,
    Indian,
    Italian,
    Japanese,
    Jordanian,
    Kabab,
    Korean,
    Lebanese,
    Mexican,
    MiddleEastern,
    Pasta,
    Pie,
    Pizza,
    Rice,
    Salads,
    Sandwiches,
    Seafood,
    Soup,
    Steak,
    Sushi,
    Turkish,
}

public enum IngredientCategorys
{
    // Protein - Meat
    Beef,
    Pork,
    Lamb,
    Goat,
    Chicken,
    Turkey,
    Duck,
    GameMeat,

    // Protein - Seafood
    Fish,
    Shellfish,
    Mollusks,

    // Protein - Plant-based
    Legumes,
    Tofu,
    Tempeh,
    Seitan,
    PlantBasedMeat,

    // Dairy & Eggs
    Milk,
    Cream,
    Cheese,
    Butter,
    Ghee,
    Yogurt,
    Eggs,

    // Grains & Cereals
    Rice,
    Pasta,
    WheatFlour,
    Couscous,
    Bulgur,
    Quinoa,
    Millet,
    Barley,
    Oats,
    Corn,
    Polenta,

    // Fruits
    FreshFruits,
    Citrus,
    TropicalFruits,
    DriedFruits,

    // Vegetables
    LeafyGreens,
    RootVegetables,
    Alliums,
    Nightshades,
    Cruciferous,
    Mushrooms,
    SquashPumpkinZucchini,
    PeasBeansCorn,

    // Oils & Fats
    VegetableOils,
    OliveOil,
    AnimalFats,
    CoconutOil,

    // Herbs & Spices
    FreshHerbs,
    DriedHerbs,
    GroundSpices,
    WholeSpices,
    SeasoningBlends,

    // Sweeteners
    Sugar,
    Honey,
    MapleSyrup,
    Agave,
    Molasses,
    ArtificialSweeteners,

    // Beverages & Liquids
    Water,
    BrothStock,
    Wine,
    Beer,
    Spirits,
    Vinegar,
    SoySauce,
    FishSauce,
    OtherFermentedSauces,

    // Nuts & Seeds
    Nuts,
    Seeds,
    NutButters,

    // Baking & Miscellaneous
    BakingPowder,
    BakingSoda,
    Yeast,
    Chocolate,
    Cocoa,
    Coffee,
    Tea,
    Gelatin,
    Agar,
    Condiments,
    PicklesFermentedItems,

    // Specialty / Optional
    ExoticHerbsFlowers,
    Seaweed,
    Truffle,
    TruffleOil,
    SpecialtyCheesesMeats
}

public enum DifficultyLevels
{
    easy,
    medium,
    hard
}

public enum CourseTypes
{
    Breakfast,
    Lunch,
    Dinner
}

public enum Statuses
{
    Pending,
    Approved
}

public enum MeasurementUnit
{
    None,
    Gram,
    Kilogram,
    Milligram,
    Liter,
    Milliliter,
    Cup,
    Tablespoon,
    Teaspoon,
    Ounce,
    Pound,
    Pinch,
    Piece,
    Slice,
    Clove,
    Bunch,
    Stick,
    Can,
    Bottle,
    Package,
    Sheet,
    Drop,
    Handful
}

public enum Ratings
{
    None = 0,
    Poor = 1,
    Fair = 2,
    Good = 3,
    VeryGood = 4,
    Excellent = 5
}