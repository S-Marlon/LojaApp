namespace LojaApp.Pages.produtos;

public partial class CadastrarProdutos : ContentPage
{
    public CadastrarProdutos()
    {
        InitializeComponent();
    }

    private void inicio(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}