
using Core.Models;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Controllers
{
    public class HourController : DateController
    {
        protected override int BranchId { get; set; }
        protected override int StemId { get; set; }
        protected override Sexagenary SexagenaryRow { get; set; }

        internal void Initialize(int hour, int dayStemId, ICalendarRepository calendar)
        {
            base.Initialize(calendar);
            BranchId = _branches.SingleOrDefault(x => x.StartHour == hour || x.EndHour == hour).Id;
            StemId = GetStemId(hour, BranchId, dayStemId);
            SexagenaryRow = _sexagenary.SingleOrDefault(x => x.BranchId == BranchId && x.StemId == StemId);
            base.Create();
        }

        private int GetStemId(int hour, int branchId, int dayStemId)
        {
            const int lateRatHour = 23;
            const int decade = 10;
            var stemId = _stems.SingleOrDefault(x => x.Id == dayStemId).HourKey;
            var id = (hour == lateRatHour)
                ? stemId + (++branchId)
                : stemId + (++branchId);
            return (id > decade) ? id - decade : id;
        }
    }
}
