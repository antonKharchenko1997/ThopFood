namespace ThopFood.Models;

public class RecipeModel
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
    public bool Favorite { get; set; }
}