namespace LojaApp.Views;

public partial class SidebarView : ContentView
{
    public event EventHandler<string> MenuItemSelected;
    public SidebarView()
    {
        InitializeComponent();
    }


    private void OnMenuItemClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string pageName)
        {
            MenuItemSelected?.Invoke(this, pageName);
        }
    }
}