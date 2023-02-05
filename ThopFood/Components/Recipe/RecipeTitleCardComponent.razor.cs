using Microsoft.AspNetCore.Components;
using ThopFood.Models;

namespace ThopFood.Components.Recipe;

public partial class RecipeTitleCardComponent
{
    private bool Loaded => Recipe != null;

    [Parameter] public RecipeModel Recipe { get; set; }
    [Parameter] public EventCallback OnRecipeChange { get; set; }

    private async Task FavoriteClick()
    {
        Recipe.Favorite = !Recipe.Favorite;
        await OnRecipeChange.InvokeAsync().ConfigureAwait(false);
    }
}
