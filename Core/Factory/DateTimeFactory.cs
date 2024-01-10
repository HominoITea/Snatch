using Core.Controllers;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Factory
{
    public static class DateTimeFactory
    {
        public static DateController GetDay(DateTime targetDate, ISolarCalendar calendar)
        {
            var dateTime = new DayController();
            dateTime.Initialize(targetDate, calendar);
            return dateTime;
        }
        public static DateController GetMonth(int yearStemId, float seasonAngle, ISolarCalendar calendar)
        {
            var dateTime = new MonthController();
            dateTime.Initialize(yearStemId, seasonAngle, calendar);
            return dateTime;
        }
        public static DateController GetYear(DateTime targetDate, float seasonAngle, ISolarCalendar calendar)
        {
            var dateTime = new YearController();
            dateTime.Initialize(targetDate, seasonAngle, calendar);
            return dateTime;
        }
        public static DateController GetHour(int hour, int dayStemId, ISolarCalendar calendar)
        {
            var dateTime = new HourController();
            dateTime.Initialize(hour, dayStemId, calendar);
            return dateTime;
        }
    }
}
