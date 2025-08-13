using LojaApp.Pages.produtos;
using LojaApp.Pages.Servicos;
using LojaApp.Pages;


namespace LojaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CadastrarProdutos), typeof(CadastrarProdutos));
            Routing.RegisterRoute(nameof(CadastrarServico), typeof(CadastrarServico));

        }

    }
}
