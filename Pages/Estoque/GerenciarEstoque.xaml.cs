namespace LojaApp.Pages.Estoque;

public partial class GerenciarEstoque : ContentPage
{
    public GerenciarEstoque()
    {
        InitializeComponent();
    }

    private async void inicio(object sender, EventArgs e)
    {
        // A forma correta de voltar usando a navega��o do Shell.
        await Shell.Current.GoToAsync("..");
    }
}