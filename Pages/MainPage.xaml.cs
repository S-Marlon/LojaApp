using LojaApp.Views;
using LojaApp.Pages.Estoque;
using LojaApp.Pages.produtos;
using LojaApp.Pages.Relatorios;
using LojaApp.Pages.Servicos;
using LojaApp.Pages.Vendas;
using Microsoft.Maui.Controls;

namespace LojaApp.Pages
{
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
            IsSidebarOpen = false; // Close sidebar after selection
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
                case "Settings":
                    mainContentArea.Content = new SettingsView();
                    break;
                case "Profile":
                    mainContentArea.Content = new ProfileView();
                    break;
                case "Servico":
                    mainContentArea.Content = new CadastroServicoView();
                    break;
                default:
                    mainContentArea.Content = new DashboardView(); // Fallback
                    break;
            }
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
           //Navigation.PushAsync(new RelatoriosPage());
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

        private async void OnBotaoServicosClicked(object sender, EventArgs e)
        {
            // Navega para a rota registrada
            await Shell.Current.GoToAsync("servicosPage");
        }




    }

}
