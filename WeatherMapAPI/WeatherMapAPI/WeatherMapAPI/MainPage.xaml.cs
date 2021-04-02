using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherMapAPI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        const string API_KEY = "36137b0ef8ddc2be72f28b385de4e3e1";

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnShowTemp_Clicked(object sender, EventArgs e)
        {
            if (EntryZipCode.Text != "")
            {
                using (WebClient wc = new WebClient())
                {
                    try
                    {
                        string json = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={EntryZipCode.Text}&appid={API_KEY}&units=imperial");

                        JObject jo = JObject.Parse(json);
                        // variable for the main objects of the api
                        JObject main = JObject.Parse(jo["main"].ToString());
                        JObject sys = JObject.Parse(jo["sys"].ToString());
                        JObject wind = JObject.Parse(jo["wind"].ToString());
                        // variables to match the api names and the GV strings
                        WeatherGV.CurTemp = main["temp"].ToString();
                        WeatherGV.LowTemp = main["temp_min"].ToString();
                        WeatherGV.HighTemp = main["temp_max"].ToString();
                        WeatherGV.Pressure = main["pressure"].ToString();
                        WeatherGV.Humidity = main["humidity"].ToString();
                        WeatherGV.Sunrise = sys["sunrise"].ToString();
                        WeatherGV.Sunset = sys["sunset"].ToString();
                        WeatherGV.WindSpeed = wind["speed"].ToString();
                        WeatherGV.WindDirection = wind["deg"].ToString();
                        // Gives the name that came from zipcode in json
                        WeatherGV.CityName = jo["name"].ToString();


                        Navigation.PushAsync(new WeatherPage());

                    }
                    catch (Exception ex)
                    {

                        DisplayAlert("Error", ex.Message, "Close");
                    }

                }
            }
            else
            {
                DisplayAlert("Invalid Input", "Please type in a zip code", "Close");
            }
        }
    }
}
