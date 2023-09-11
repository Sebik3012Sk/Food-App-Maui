using RestSharp;
using FoodApp.Pages;

namespace FoodApp.Pages.Admin;


public partial class AddRecipe : ContentPage
{

    const string url = "http://localhost:8080/post-datadb";

    public AddRecipe()
	{
		InitializeComponent();
	}

	private async void AddNewRecipe(object sender , EventArgs e)
	{

		RestClient client = new RestClient(url);
		RestRequest request = new RestRequest("",Method.Post);

		request.AddJsonBody(new { title = title_entry.Text, image = image_entry.Text, recipe_text = recipeText_entry.Text });

		var response = client.Execute(request);

		if(response.IsSuccessful)
		{
			await DisplayAlert("Food App", "Success Full Add Recipe","ok","cancel");
            await Navigation.PushAsync(new AllRecipes());
        }
        else
		{
			await DisplayAlert("Food App", "Error to Add Recipe", "ok", "cancel");
		}

		
	}
}