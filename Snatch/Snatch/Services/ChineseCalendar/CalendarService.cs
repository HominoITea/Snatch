﻿using CelestialComputation;
using Core.Factory;
using Snatch.Models;
using System;
using System.Threading.Tasks;
using Core.Models.DTOs;
using Core.Repository;

namespace Snatch.Services.ChineseCalendar
{
    public class CalendarService : ICalendarService
    {
        private readonly ICalendarRepository _calendarRepository;
        private readonly DateTime _targetDate;
        private readonly float _currentSeasonAngle;

        public CalendarService(ICalendarRepository calendarRepository, DateTime targetDate)
        {
            _calendarRepository = calendarRepository;
            _targetDate = targetDate;
            _currentSeasonAngle = Celestial.GetEclipticLongitude(targetDate);
        }
        public async Task<CalendarItem> GetYearInfoAsync()
        {
            return await Task.Run(() =>
            {
                var requestResult = DateTimeFactory.GetYear(_targetDate, _currentSeasonAngle, _calendarRepository);
                return GetCalendarItem(requestResult.Sexagenary);
            })
            .ConfigureAwait(false);
        }
        public async Task<CalendarItem> GetMonthInfoAsync(Func<Task<CalendarItem>> yearFunc)
        {
            return await Task.Run(async () =>
            {
                var yearInfo = await yearFunc().ConfigureAwait(false);
                var requestResult = DateTimeFactory.GetMonth(yearInfo.Stem.Id, _currentSeasonAngle, _calendarRepository);
                return GetCalendarItem(requestResult.Sexagenary);
            })
            .ConfigureAwait(false);            
        }
        public async Task<CalendarItem> GetDayInfoAsync()
        {
            return await Task.Run(() =>
            {
                var requestResult = DateTimeFactory.GetDay(_targetDate, _calendarRepository);
                return GetCalendarItem(requestResult.Sexagenary);
            })
            .ConfigureAwait(false);
        }
        public async Task<CalendarItem> GetHourInfoAsync(int dayId)
        {
            return await Task.Run(() =>
            {
                var requestResult = DateTimeFactory.GetHour(_targetDate.Hour, dayId, _calendarRepository);
                return GetCalendarItem(requestResult.Sexagenary);
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
