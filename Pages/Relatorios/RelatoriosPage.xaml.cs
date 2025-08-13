namespace LojaApp.Pages.Relatorios;

public partial class RelatoriosPage : ContentPage
{
    public RelatoriosPage()
    {
        InitializeComponent();
    }

    private void inicio(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}