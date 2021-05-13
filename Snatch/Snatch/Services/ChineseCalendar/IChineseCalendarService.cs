using Core.Interfaces;
using Snatch.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Snatch.Services.ChineseCalendar
{
    interface IChineseCalendarService
    {
        public Task<CalendarItem> GetYearInfoAsync();
        public Task<CalendarItem> GetMonthInfoAsync(Func<Task<CalendarItem>> yearFunc);
        public Task<CalendarItem> GetDayInfoAsync();
        public Task<CalendarItem> GetHourInfoAsync(int dayId);        
    }
}
