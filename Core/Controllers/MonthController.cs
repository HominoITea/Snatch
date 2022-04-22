using Core.Infrastructure.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Repository;

namespace Core.Controllers
{
    public class MonthController : DateController
    {
        protected override int BranchId { get; set; }
        protected override int StemId { get; set; }
        protected override Sexagenary SexagenaryRow { get; set; }
        internal void Initialize(int yearStemId, float seasonAngle, ICalendarRepository calendar)
        {
            base.Initialize(calendar);
            BranchId = GetBranchId((int)seasonAngle);
            StemId = GetStemId((BranchesEnumerator)BranchId, yearStemId);
            SexagenaryRow = _sexagenary.FirstOrDefault(x => x.BranchId == BranchId && x.StemId == StemId);
            base.Create();
        }
        private int GetBranchId(int seasonAngle)
        {
            const int eclipticStartOfRabbitMonth = 345;
            const int eclipticEndOfRabbitMonth = 15;
            return seasonAngle >= eclipticStartOfRabbitMonth || seasonAngle < eclipticEndOfRabbitMonth //Залипуха, потому что от 345 до 15 встречается ноль и branchPath не срабатывает
                    ? (int)BranchesEnumerator.Rabbit
                    : _branches.FirstOrDefault(x => x.EclipticStart <= seasonAngle && x.EclipticEnd > seasonAngle).Id;
        }
        private int GetStemId(BranchesEnumerator branch, int yearStemId)
        {
            const int decade = 10;
            var monthKey = _stems.FirstOrDefault(x => x.Id == yearStemId).MonthKey;
            var id = (branch > BranchesEnumerator.Ox) switch
            {
                true => monthKey + branch - BranchesEnumerator.Tiger,
                false => monthKey + branch - BranchesEnumerator.Rat
            };
            return id > decade ? id - decade : id;
        }
    }
}
