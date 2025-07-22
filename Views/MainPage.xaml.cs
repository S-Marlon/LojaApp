using LojaApp.Views.Estoque;
using LojaApp.Views.produtos;
using LojaApp.Views.relatorios;
using LojaApp.Views.Servicos;
using LojaApp.Views.Vendas;

namespace LojaApp
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
                DisplayAlert("Hello", "Welcome to LojaApp!", "Bleleza");
        }

        private void servicoClicked(object sender, EventArgs e)
        {
            DisplayAlert("Indo para a tela", "Cadastrar servico", "Bleleza");
            Navigation.PushAsync(new CadastrarServico());
        }

        private void estoqueClicked(object sender, EventArgs e)
        {
            DisplayAlert("Indo para a tela", "Cadastrar servico", "Bleleza");
            Navigation.PushAsync(new GerenciarEstoque());
        }

        private void relatoriosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Indo para a tela", "Cadastrar servico", "Bleleza");
            Navigation.PushAsync(new Relatorios());
        }

        private void produtosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Indo para a tela", "Cadastrar servico", "Bleleza");
            Navigation.PushAsync(new CadastrarProdutos());
        }

        private void vendasClicked(object sender, EventArgs e)
        {
            DisplayAlert("Indo para a tela", "Cadastrar servico", "Bleleza");
            Navigation.PushAsync(new NovaVenda());
        }




    }

}
