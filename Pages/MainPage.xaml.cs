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
        

        private bool _isSidebarOpen;
        public bool IsSidebarOpen
        {
            get => _isSidebarOpen;
            set
            {
                if (_isSidebarOpen != value)
                {
                    _isSidebarOpen = value;
                    OnPropertyChanged(nameof(IsSidebarOpen));
                }
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PessoaViewModel(); // DataContext definido
            this.BindingContext = this; // Set the BindingContext for IsSidebarOpen

            // Subscribe to the MenuItemSelected event from the sidebar
            sidebar.MenuItemSelected += OnSidebarMenuItemSelected;

            // Load the initial content
            LoadContent("Dashboard");
        }

        private void OnToggleSidebarClicked(object sender, EventArgs e)
        {
            IsSidebarOpen = !IsSidebarOpen;
            
        }

        private void OnSidebarMenuItemSelected(object sender, string pageName)
        {
            LoadContent(pageName);
            // IsSidebarOpen = false; // Close sidebar after selection
        }

        private void LoadContent(string pageName)
        {
            // Clear existing content
            mainContentArea.Content = null;

            // Dynamically load the appropriate ContentView based on pageName
            switch (pageName)
            {
                case "Dashboard":
                    mainContentArea.Content = new DashboardView();
                    break;
                case "produtos":
                    mainContentArea.Content = new CadastrarProdutosView();
                    break;
                case "Estoque":
                    mainContentArea.Content = new GerenciarEstoqueView();
                    break;
                case "Servico":
                    mainContentArea.Content = new CadastroServicoView();
                    break;
                default:
                    mainContentArea.Content = new DashboardView(); // Fallback
                    break;
            }
        }
      

    }

}
