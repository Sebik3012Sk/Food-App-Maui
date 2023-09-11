using RestSharp;
using Newtonsoft.Json;
using Microsoft.Maui.Controls.Shapes;

namespace FoodApp.Pages;

public partial class AllRecipes : ContentPage
{

    const string url = "http://localhost:8080/api-data";

    public AllRecipes()
	{
		InitializeComponent();
        LoadPage();
	}

    private void LoadPage()
    {
        RestClient client = new RestClient(url);
        RestRequest request = new RestRequest();
        var response = client.Get(request);
        var data_json = JsonConvert.DeserializeObject<dynamic>(response.Content);

        foreach (var one_data in data_json)
        {
            Image image = new Image();
            Label title = new Label();
           

            ImageSource imageSource = new UriImageSource
            {
                Uri = new Uri(one_data.image.ToString()),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(1, 0, 0, 0)
            };

            image.Source = imageSource;
            image.WidthRequest = 250;
            image.HeightRequest = 250;

            title.Text = one_data.title;

            layout.Children.Add(image);
            layout.Children.Add(title);
        }

    }
}