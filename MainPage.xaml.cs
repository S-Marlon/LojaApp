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
    }

}
