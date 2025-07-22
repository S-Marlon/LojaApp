namespace LojaApp.Views.Estoque;

public partial class GerenciarEstoque : ContentPage
{
	public GerenciarEstoque()
	{
		InitializeComponent();
	}

    private void inicio(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}