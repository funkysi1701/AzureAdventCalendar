using System;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAdventCalendar.Data
{
    public class WeatherForecastService
    {
        public Task<WeatherForecast[]> GetForecastAsync()
        {
            WeatherForecast[] sleigh = new WeatherForecast[9];
            var r1 = new WeatherForecast
            {
                Name = "Dasher",
                Speed = 655,
            };
            var r2 = new WeatherForecast
            {
                Name = "Dancer",
                Speed = 653,
            };
            var r3 = new WeatherForecast
            {
                Name = "Prancer",
                Speed = 650,
            };
            var r4 = new WeatherForecast
            {
                Name = "Vixen",
                Speed = 649
            };
            var r5 = new WeatherForecast
            {
                Name = "Comet",
                Speed = 657,
            };
            var r6 = new WeatherForecast
            {
                Name = "Cupid",
                Speed = 656,
            };
            var r7 = new WeatherForecast
            {
                Name = "Donner",
                Speed = 662,
            };
            var r8 = new WeatherForecast
            {
                Name = "Blitzen",
                Speed = 659,
            };
            var r9 = new WeatherForecast
            {
                Name = "Rudolph",
                Speed = 665,
            };
            sleigh[0] = r1;
            sleigh[1] = r2;
            sleigh[2] = r3;
            sleigh[3] = r4;
            sleigh[4] = r5;
            sleigh[5] = r6;
            sleigh[6] = r7;
            sleigh[7] = r8;
            sleigh[8] = r9;
            return Task.FromResult(sleigh);
        }
    }
}