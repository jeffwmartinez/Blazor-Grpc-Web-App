using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorGrpcWebApp.Shared
{
    public partial class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int temperatureC { get; set; }

        public string summary { get; set; }

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
