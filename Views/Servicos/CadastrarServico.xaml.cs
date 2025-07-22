namespace LojaApp.Views.Servicos;

public partial class CadastrarServico : ContentPage
{
	public CadastrarServico()
	{
		InitializeComponent();
	}

    private void inicio(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}