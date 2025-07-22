namespace LojaApp.Views.Vendas;

public partial class NovaVenda : ContentPage
{
	public NovaVenda()
	{
		InitializeComponent();
	}

    private void inicio(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}