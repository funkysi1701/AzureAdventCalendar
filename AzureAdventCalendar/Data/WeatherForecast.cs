using System;

namespace AzureAdventCalendar.Data
{
    public class WeatherForecast
    {
        public string Name { get; set; }

        public int Speed { get; set; }

        public int SpeedKPH => (int)(Speed * 1.609);
    }
}