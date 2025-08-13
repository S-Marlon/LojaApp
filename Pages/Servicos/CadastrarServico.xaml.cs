namespace LojaApp.Pages.Servicos;

public partial class CadastrarServico : ContentPage
{
    public CadastrarServico()
    {
        InitializeComponent();
        BindingContext = new MaterialModelo();
    }

    private async void inicio(object sender, EventArgs e)
    {
        // A forma correta de voltar usando a navegação do Shell.
        await Shell.Current.GoToAsync("..");
    }
}