using Microsoft.AspNetCore.Components;
using ThopFood.Models;

namespace ThopFood.Components.Recipe;

public partial class RecipeTitleComponent
{
    [Parameter] public RecipeModel Recipe { get; set; }
    public bool Loaded => Recipe != null;
}