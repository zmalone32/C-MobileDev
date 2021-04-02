using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherMapAPI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            LblCityName.Text = $"City: {WeatherGV.CityName}";
            LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp} degrees";
            LblHighTemp.Text = $"High Temp: {WeatherGV.HighTemp} degrees";
            LblLowTemp.Text = $"Low Temp: {WeatherGV.LowTemp} degrees";
            LblPressure.Text = $"Pressure: {WeatherGV.Pressure}";
            LblHumidity.Text = $"Humidity: {WeatherGV.Humidity}";
            LblSunrise.Text = $"Sunrise: {WeatherGV.Sunrise}";
            LblSunset.Text = $"Sunset: {WeatherGV.Sunset}";
            LblWindSpeed.Text = $"Wind Speed: {WeatherGV.WindSpeed}";
            LblWindDir.Text = $"Wind Direction: {WeatherGV.WindDirection}";
        }
    }
}