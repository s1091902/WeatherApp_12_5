//using AudioToolbox;
using WeatherApp.Services;

namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		var result = await ApiService.GetWeather(24.1469,123.6839);
		lblCity.Text = result.City.Name;
		//LblWeatherDescription.Text = result.List[0].Weather[0].Description;
		LblTemperature.Text = result.List[0].Main.tempterature + "C";
		LblHumidity.Text = result.List[0].Main.Humidity + "%";
		LblWind.Text = result.List[0].Wind.Speed + "km/h";
	}


}