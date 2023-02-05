using ThopFood.Models;

namespace ThopFood.Contracts.Services;

public interface IRecipeService
{
    public Task<RecipeModel?> GetRecipe(string id);
}
