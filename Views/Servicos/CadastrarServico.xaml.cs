namespace LojaApp.Views.Servicos;

public partial class CadastrarServico : ContentPage
{
	public CadastrarServico()
	{
		InitializeComponent();
        BindingContext = new MaterialModelo();
    }

    private async void inicio(object sender, EventArgs e)
    {
        // A forma correta de voltar usando a navega��o do Shell.
        await Shell.Current.GoToAsync("..");
    }
}