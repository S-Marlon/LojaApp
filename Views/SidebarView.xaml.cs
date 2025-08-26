using LojaApp.ViewModels;

namespace LojaApp.Views;

public partial class SidebarView : ContentView
{
    public event EventHandler<string> MenuItemSelected;
    public SidebarView()
    {
        InitializeComponent();
        BindingContext = new SidebarViewModel();
    }
   

    private void OnMenuItemClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string pageName)
        {
            MenuItemSelected?.Invoke(this, pageName);
        }

    }

    private void OnMenuItemTapped(object sender, EventArgs e)
    {
        if (sender is Grid grid && grid.GestureRecognizers.FirstOrDefault() is TapGestureRecognizer tapGestureRecognizer)
        {
            // O parâmetro vem do CommandParameter
            var pageName = tapGestureRecognizer.CommandParameter as string;
            if (!string.IsNullOrEmpty(pageName))
            {
                MenuItemSelected?.Invoke(this, pageName);
            }
        }
    }


}


