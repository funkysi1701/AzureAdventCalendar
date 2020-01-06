using AzureAdventCalendar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAdventCalendar.Data
{
    public class WeatherForecastService
    {
        private AzureAdventContext _context;

        public WeatherForecastService(AzureAdventContext context)
        {
            _context = context;
        }

        public async Task<List<Reindeer>> GetForecastAsync()
        {
            return await _context.Reindeer.OrderBy(x => x.Id).ToListAsync();
        }
    }
}