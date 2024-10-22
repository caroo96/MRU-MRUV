namespace AplicacionFisica;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void GoToConversion(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Conversiones());
    }
}