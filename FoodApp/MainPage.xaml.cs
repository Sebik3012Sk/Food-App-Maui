namespace FoodApp;
using FoodApp.Pages;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void PushOnRgisterPage(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Register());
    }
}

