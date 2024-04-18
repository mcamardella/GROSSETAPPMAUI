using Android.Graphics.Drawables;
using GROSSETAPPMAUI.Models;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Net.Http.Json;

namespace GROSSETAPPMAUI;

public partial class WeatherPage : ContentPage
{
    private string _baseUrlGare = "https://api.jsonbin.io/v3/b/662034fead19ca34f85bbe8b";
    private readonly HttpClient _httpClient;
    public string Status = "sunny";

    public ObservableCollection<DailyCityModel> DailyCityList { get; set; } = new();

    public DateTime today = DateTime.Today;
    public WeatherPage()
	{
		InitializeComponent();
        _httpClient = new HttpClient();
        BindingContext = this;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        onLoading();
    }

    public async void onLoading()
    {
        DailyCityList.Clear();
        var response = await _httpClient.GetFromJsonAsync<WeatherRootModel>(_baseUrlGare);
        response?.Record.Timelines.Daily.ForEach(daily => DailyCityList.Add(daily));

        StatusImage.Text = "sunny";

        foreach(var daily in DailyCityList)
        {
            DateTime today = DateTime.Today;

            string dateString = daily.Time.ToString();

            DateTime DailyDateTime = DateTime.Parse(dateString);

            if (DailyDateTime.Date == today)
            {
                StatusImage.Text = ConverteSytringToIcon(daily.Status);
                StatusTemp.Text = daily.Values.temperatureAvg.ToString() + " °C";
            }

            daily.Status = ConverteSytringToIcon(daily.Status);

        }
    }

    public string ConverteSytringToIcon(string StatusString)
    {
        string emojn = "☀️";
        if (StatusString == "sunny")
        {
            emojn = "☀️";
        }
        else if (StatusString == "cloudy")
        {
            emojn = "☁️";
        }
        else if (StatusString == "thunderstorm")
        {
            emojn = "⛈️";
        }
        else if (StatusString == "windy")
        {
            emojn = "🌬️";
        }
        else if (StatusString == "rainy")
        {
            emojn = "🌧️";
        }
        return emojn;
    }
}