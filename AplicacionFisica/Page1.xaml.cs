namespace AplicacionFisica;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false); 
    }      

    private async void GoToVelocidadConstante(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VelocidadConstante());
    }

    private async void GoToVelocidadAcelerada(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VelocidadAcelerada());
    }


}

