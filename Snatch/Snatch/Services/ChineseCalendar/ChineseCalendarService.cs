using CelestialComputation;
using Core.Interfaces;
using Core.Factory;
using Snatch.Models;
using System;
using System.Threading.Tasks;
using Core.Models.DTOs;

namespace Snatch.Services.ChineseCalendar
{
    public class ChineseCalendarService : IChineseCalendarService
    {
        private readonly ISolarCalendar _solarCalendar;
        private readonly DateTime _targetDate;
        private readonly float _currentSeasonAngle;

        public ChineseCalendarService(ISolarCalendar solarCalendar, DateTime targetDate)
        {
            _solarCalendar = solarCalendar;
            _targetDate = targetDate;
            _currentSeasonAngle = Celestial.EclipticLongitude(targetDate);
        }
        public async Task<CalendarItem> GetYearInfoAsync()
        {
            return await Task.Run(() =>
            {
                var requestResult = DateTimeFactory.GetYear(_targetDate, _currentSeasonAngle, _solarCalendar).Sexagenary;
                return GetCalendarItem(requestResult);
            })
            .ConfigureAwait(false);
        }
        public async Task<CalendarItem> GetMonthInfoAsync(Func<Task<CalendarItem>> yearFunc)
        {
            return await Task.Run(async () =>
            {
                var yearInfo = await yearFunc().ConfigureAwait(false);
                var requestResult = DateTimeFactory.GetMonth(yearInfo.Stem.Id, _currentSeasonAngle, _solarCalendar).Sexagenary;
                return GetCalendarItem(requestResult);
            })
            .ConfigureAwait(false);            
        }
        public async Task<CalendarItem> GetDayInfoAsync()
        {
            return await Task.Run(() =>
            {
                var requestResult = DateTimeFactory.GetDay(_targetDate, _solarCalendar).Sexagenary;
                return GetCalendarItem(requestResult);
            })
            .ConfigureAwait(false);
        }
        public async Task<CalendarItem> GetHourInfoAsync(int dayId)
        {
            return await Task.Run(() =>
            {
                var requestResult = DateTimeFactory.GetHour(_targetDate.Hour, dayId, _solarCalendar).Sexagenary;
                return GetCalendarItem(requestResult);
            })
            .ConfigureAwait(false);            
        }

        private CalendarItem GetCalendarItem(SexagenaryDTO requestResult)
        {
            return new CalendarItem
            {
                Branch = requestResult.Branch,
                Stem = requestResult.Stem,
                Dagua = requestResult.Dagua,
                Period = requestResult.Period,
                WuxingId = requestResult.WuxingId
            };
        }
    }
}
