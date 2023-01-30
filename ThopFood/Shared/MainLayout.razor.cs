using MudBlazor;

namespace ThopFood.Shared;

public partial class MainLayout
{
    private  bool _drawerOpen = true;

    public MudTheme MudTheme = new()
    {
        Palette = new Palette
        {
            Primary = "#8FC93A",
            AppbarBackground = "#8FC93A",
            Secondary = "#508CA4",
            Background = "#F6FAFA",
            BackgroundGrey = "#F0F7F4",
        },
    };

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }    
}