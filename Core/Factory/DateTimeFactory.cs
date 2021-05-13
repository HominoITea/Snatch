using Core.Controllers;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Factory
{
    public static class DateTimeFactory
    {
        public static ChineseDateController GetDay(DateTime targetDate, ISolarCalendar calendar)
        {
            var dateTime = new ChineseDayController();
            dateTime.Initialize(targetDate, calendar);
            return dateTime;
        }
        public static ChineseDateController GetMonth(int yearStemId, float seasonAngle, ISolarCalendar calendar)
        {
            var dateTime = new ChineseMonthController();
            dateTime.Initialize(yearStemId, seasonAngle, calendar);
            return dateTime;
        }
        public static ChineseDateController GetYear(DateTime targetDate, float seasonAngle, ISolarCalendar calendar)
        {
            var dateTime = new ChineseYearController();
            dateTime.Initialize(targetDate, seasonAngle, calendar);
            return dateTime;
        }
        public static ChineseDateController GetHour(int hour, int dayStemId, ISolarCalendar calendar)
        {
            var dateTime = new ChineseHourController();
            dateTime.Initialize(hour, dayStemId, calendar);
            return dateTime;
        }
    }
}
