using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Repository;

namespace Core.Controllers
{
    public class DayController : DateController
    {
        protected override int BranchId { get; set; }
        protected override int StemId { get; set; }
        protected override Sexagenary SexagenaryRow { get; set; }
        private static int GetDayNumber(DateTime targetDate)
        {
            const int cycleNumber = 0;
            const int sexagenary = 60;
            var initialDate = new DateTime(1944, 1, 1);
            var days = targetDate.Subtract(initialDate).Days;
            var remainder = days - days / sexagenary * sexagenary;
            return remainder > cycleNumber
                ? remainder
                : cycleNumber;
        }

        internal void Initialize(DateTime targetDate, ICalendarRepository calendar)
        {
            base.Initialize(calendar);
            SexagenaryRow = _sexagenary.ElementAt(GetDayNumber(targetDate)); 
            BranchId = SexagenaryRow.BranchId; 
            StemId = SexagenaryRow.StemId;

            base.Create();
        }
    }
}
