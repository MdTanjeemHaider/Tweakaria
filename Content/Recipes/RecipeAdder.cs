using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public static class RecipeAdder
{
    // For statue recipes with ingredients
    public static void Statue(int ResultID, int IngredientID, int IngredientAmount)
    {
        Recipe R = Recipe.Create(ResultID);
        if (IngredientID != 0)
        {
            R.AddIngredient(IngredientID, IngredientAmount);
        }
        R.AddIngredient(ItemID.StoneBlock, 50);
        R.AddTile(TileID.HeavyWorkBench);
        R.Register();
    }

    // For statue recipes with recipe groups
    public static void Statue(int ResultID, string GroupID, int GroupAmount)
    {
        Recipe R = Recipe.Create(ResultID);
        R.AddRecipeGroup(GroupID, GroupAmount);
        R.AddIngredient(ItemID.StoneBlock, 50);
        R.AddTile(TileID.HeavyWorkBench);
        R.Register();
    }

    // For exchange recipes
    public static void TwoWayExchange(int Item1, int Item2)
    {
        Recipe R = Recipe.Create(Item1);
        R.AddIngredient(Item2);
        R.AddTile(ModContent.TileType<AlterationOrbTile>());
        R.Register();

        R = Recipe.Create(Item2);
        R.AddIngredient(Item1);
        R.AddTile(ModContent.TileType<AlterationOrbTile>());
        R.Register();
    }

    public static void ThreeWayExchange(int Item1, int Item2, int Item3)
    {
        TwoWayExchange(Item1, Item2);
        TwoWayExchange(Item1, Item3);
        TwoWayExchange(Item2, Item3);
    }

    public static void FourWayExchange(int Item1, int Item2, int Item3, int Item4)
    {
        ThreeWayExchange(Item1, Item2, Item3);
        TwoWayExchange(Item1, Item4);
        TwoWayExchange(Item2, Item4);
        TwoWayExchange(Item3, Item4);
    }

    // For Melt recipes
    public static void Melt(int IngredientID, int ResultID, int ResultAmount)
    {
        Recipe R = Recipe.Create(ResultID, ResultAmount);
        R.AddIngredient(IngredientID);
        R.AddTile(TileID.Hellforge);
        R.Register();
    }

    // For Generic recipes that can use both ingredients and recipe groups
    public static void Generic(int ResultID, int ResultAmount, (short ID, int Amount)[] Ingredients, (string ID, int Amount)[] IngredientsGroup, int TileID)
    {
        Recipe R = Recipe.Create(ResultID, ResultAmount);
        if (Ingredients != null)
        {
            for (int i=0; i < Ingredients.Length; i++)
            {
                R.AddIngredient(Ingredients[i].ID, Ingredients[i].Amount);
            }  
        }

        if (IngredientsGroup != null)
        {
            for (int i=0; i < IngredientsGroup.Length; i++)
            {
                R.AddRecipeGroup(IngredientsGroup[i].ID, IngredientsGroup[i].Amount);
            }
        }
        R.Register();
    }
}