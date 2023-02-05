using ThopFood.Contracts.Services;
using ThopFood.Models;

namespace ThopFood.Services;

public class RecipeService : IRecipeService
{
    public Task<RecipeModel?> GetRecipe(string id)
    {
        return Task.FromResult(new RecipeModel
        {
            Title = "Donuts and more",
            Description = "Very nice food. It smells amazing!!!!",
            ImageUrl = "https://cdn-icons-png.flaticon.com/512/2821/2821785.png",
        });
    }
}
