using  static LojaApp.MainPage;

namespace LojaApp
{
    public partial class AppShell : FlyoutPage
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private async void OnMainPageClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
            IsPresented = false; // Fecha o menu
        }

        
    }
}
