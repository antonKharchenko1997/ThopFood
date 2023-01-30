using Microsoft.AspNetCore.Components;
using ThopFood.Contracts.Services;
using ThopFood.Models;

namespace ThopFood.Pages;

public partial class Index
{
    private RecipeModel _recipe;
    
    [Inject] public IRecipeService RecipeService { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        _recipe = await RecipeService.GetRecipe("");
    }
}