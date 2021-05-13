using Core.Infrastructure.Enums;
using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Controllers
{
    public class ChineseYearController : ChineseDateController
    {
        protected override int BranchId { get; set; }
        protected override int StemId { get; set; }
        protected override Sexagenary SexagenaryRow { get; set; }
        internal void Initialize(DateTime targetDate, float seasonAngle, ISolarCalendar calendar)
        {
            base.Initialize(calendar);
            SexagenaryRow = _sexagenary[ChineseYearNum(targetDate, seasonAngle)];
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
