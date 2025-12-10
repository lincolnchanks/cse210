class User
{
    // private double _weeklyBudget;
    private List<Storage> _storagePlaces = new List<Storage>();
    private List<Recipe> _savedRecipes = new List<Recipe>();

    public void AddStoragePlace(Storage storage)
    {
        _storagePlaces.Add(storage);
    }
    public void AddRecipe(Recipe recipe)
    {
        _savedRecipes.Add(recipe);
    }
    public List<Recipe> GetSavedRecipes()
    {
        return _savedRecipes;
    }
}