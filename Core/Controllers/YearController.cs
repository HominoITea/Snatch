using Core.Infrastructure.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Repository;
using System.Linq;

namespace Core.Controllers
{
    public class YearController : DateController
    {
        protected override int BranchId { get; set; }
        protected override int StemId { get; set; }
        protected override Sexagenary SexagenaryRow { get; set; }
        internal void Initialize(DateTime targetDate, float seasonAngle, ICalendarRepository calendar)
        {
            base.Initialize(calendar);
            SexagenaryRow = _sexagenary.ElementAt(ChineseYearNum(targetDate, seasonAngle));
            BranchId = SexagenaryRow.BranchId;
            StemId = SexagenaryRow.StemId;
            base.Create();
        }
        private static int ChineseYearNum(DateTime targetDate, float seasonAngle)
        {
            const float solarNewYearPosition = 314.99F;
            const int sexagenaryCycle = 60;
            var mdYear = targetDate.Month <= (int)BranchesEnumerator.Ox && seasonAngle < solarNewYearPosition
                ? targetDate.Year - 5
                : targetDate.Year - 4;

            mdYear -= mdYear / sexagenaryCycle * sexagenaryCycle;
            return mdYear;
        }
    }
}
