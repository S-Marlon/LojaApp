namespace LojaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // Agora usa o Flyout
        }



    }
}
