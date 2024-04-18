using GROSSETAPPMAUI.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace GROSSETAPPMAUI;

public partial class CityPage : ContentPage
{
    private string _baseUrlGare = "https://api.jsonbin.io/v3/b/6620334ce41b4d34e4e60a2c";
    private readonly HttpClient _httpClient;

    public ObservableCollection<RecordCityModel> City { get; set; } = new();

    public CityPage()
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
        City.Clear();
        var response = await _httpClient.GetFromJsonAsync<CityRootModel>(_baseUrlGare);
        City.Add(response?.Record);
    }
}