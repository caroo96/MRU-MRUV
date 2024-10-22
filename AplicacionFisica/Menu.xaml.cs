namespace AplicacionFisica;

public partial class Menu : ContentPage
{
	public Menu(string nombre)
	{
		InitializeComponent();
        Saludo.Text = $"¡Hola, {nombre}!";
        NavigationPage.SetHasNavigationBar(this, false);
    }

   
    private async void GoToPage1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1()); 
    }

    private async void GoToPage2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page2());
    }

    private async void GoToPage3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }

    private async void GoToPage4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4());
    }

    private async void GoToPage5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4());
    }

    private async void GoToPage6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4());
    }
}