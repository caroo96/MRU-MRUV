namespace AplicacionFisica;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void GoToDistanciaConstante(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DistanciaConstante());
    }

    private async void GoToDistanciaAcelerada(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DistanciaAcelerada());
    }
}