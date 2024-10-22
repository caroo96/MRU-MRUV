namespace AplicacionFisica
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

          
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string nombre = NameEntry.Text;

            await Navigation.PushAsync(new Menu(nombre));


        }

    }

}
