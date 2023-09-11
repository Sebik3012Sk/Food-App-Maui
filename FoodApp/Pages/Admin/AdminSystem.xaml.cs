namespace FoodApp.Pages.Admin;

public partial class AdminSystem : ContentPage
{
	public AdminSystem()
	{
		InitializeComponent();
	}

	private async void RedirectToAddRecipe(object sender , EventArgs e)
	{
		await Navigation.PushAsync(new AddRecipe());
	}

	private async void RedirectToDeleteRecipe(object sender , EventArgs e)
	{
		await Navigation.PushAsync(new DeleteRecipe());
	}
}