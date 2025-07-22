namespace LojaApp.Views.relatorios;

public partial class Relatorios : ContentPage
{
	public Relatorios()
	{
		InitializeComponent();
	}

    private void inicio(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}