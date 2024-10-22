namespace AplicacionFisica;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void GoToTiempoConstante(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TiempoConstante());
    }

    private async void GoToTiempoAcelerado(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TiempoAcelerado());
    }
}