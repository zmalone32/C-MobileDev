using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherMapAPI
{
    public static class WeatherGV
    {
        // Prop tab-tab
        // Stays in memory all the time to be used on all pages
        public static string CityName { get; set; }
        public static string CurTemp { get; set; }
        public static string HighTemp { get; set; }
        public static string LowTemp { get; set; }
        public static string Pressure { get; set; }
        public static string Humidity { get; set; }
        public static string Sunrise { get; set; }
        public static string Sunset { get; set; }
        public static string WindSpeed { get; set; }
        public static string WindDirection { get; set; }


    }
}
