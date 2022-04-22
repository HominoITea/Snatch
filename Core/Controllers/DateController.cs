
using Core.Models;
using Core.Models.DTOs;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Controllers
{
    public abstract class DateController
    {        
        internal IEnumerable<Branch> _branches;
        internal IEnumerable<Stem> _stems;
        internal IEnumerable<Sexagenary> _sexagenary;
        protected abstract Sexagenary SexagenaryRow { get; set; }
        protected abstract int BranchId { get; set; }
        protected abstract int StemId { get; set; }
        public SexagenaryDTO Sexagenary { get; private set; }
        internal virtual void Initialize(ICalendarRepository calendar)
        {
            _branches = calendar.GetBranches();
            _stems = calendar.GetStems();
            _sexagenary = calendar.GetSexagenaries();
        }

        protected void Create()
        {
            Sexagenary = new SexagenaryDTO
            {
                Branch = _branches.FirstOrDefault(x => x.Id == BranchId), 
                Stem = _stems.FirstOrDefault(x => x.Id == StemId), 
                Dagua = SexagenaryRow.Dagua, 
                Period = SexagenaryRow.Period, 
                WuxingId = SexagenaryRow.WuxingId, 
            };
        }
    }
}
