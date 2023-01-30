using MudBlazor.Services;
using ThopFood.Contracts.Services;
using ThopFood.Services;

namespace ThopFood.Extensions;

public static class HostBuilderExtensions
{
    public static void AddMudBlazor(this IServiceCollection services)
    {
        services.AddMudServices();
    }

    public static void AddInternalServices(this IServiceCollection services)
    {
        services.AddTransient<IRecipeService, RecipeService>();
    }
}