using LojaApp.Views;
using LojaApp.Pages.Estoque;
using LojaApp.Pages.Produtos;
using LojaApp.Pages.Relatorios;
using LojaApp.Pages.Servicos;
using LojaApp.Pages.Vendas;
using Microsoft.Maui.Controls;

namespace LojaApp.Pages
{   public class PessoaViewModel
        {
            public string Nome { get; set; } = "Marlon";
        }
    public partial class MainPage : ContentPage
    {
        private bool _isSidebarOpen = true; // começa aberta
        public MainPage()
        {
            InitializeComponent();

            // Binding apenas para animação da sidebar
            this.BindingContext = this;

            // Evento de clique vindo da Sidebar
            sidebar.MenuItemSelected += OnSidebarMenuItemSelected;

            // Conteúdo inicial
            LoadContent("Dashboard");
        }
        

        private void OnToggleSidebarClicked(object sender, EventArgs e)
        {
            double target = _isSidebarOpen ? 80 : 200; // recolhe/expande
            AnimateSidebarWidth(target);
            _isSidebarOpen = !_isSidebarOpen;
        }

        private void AnimateSidebarWidth(double targetWidth)
        {
            // Usa a largura atual (WidthRequest se já definido, senão Width medido)
            double start = sidebar.WidthRequest > 0 ? sidebar.WidthRequest : sidebar.Width;

            var anim = new Animation(v => sidebar.WidthRequest = v, start, targetWidth);
            anim.Commit(this, "SidebarWidthAnim", rate: 16, length: 250, easing: Easing.CubicInOut);
        }

        private void OnSidebarMenuItemSelected(object sender, string pageName)
        {
            LoadContent(pageName);
            // IsSidebarOpen = false; // Close sidebar after selection
        }

        public void LoadContent(string pageName)
        {
            mainContentArea.Content = null;

            switch (pageName)
            {
                case "Dashboard":
                    mainContentArea.Content = new DashboardView();
                    break;

                case "Produtos":
                    mainContentArea.Content = new CadastrarProdutosView();
                    break;

                case "Estoque":
                    mainContentArea.Content = new GerenciarEstoqueView();
                    break;

                case "Servico":
                    mainContentArea.Content = new CadastroServicoView();
                    break;

                default:
                    mainContentArea.Content = new DashboardView();
                    break;
            }
        }


    }

}
