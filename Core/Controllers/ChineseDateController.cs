using Core.Interfaces;
using Core.Models;
using Core.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Controllers
{
    public abstract class ChineseDateController
    {        
        internal Branch[] _branches;
        internal Stem[] _stems;
        internal Sexagenary[] _sexagenary;
        protected abstract Sexagenary SexagenaryRow { get; set; }
        protected abstract int BranchId { get; set; }
        protected abstract int StemId { get; set; }
        public SexagenaryDTO Sexagenary { get; private set; }
        internal virtual void Initialize(ISolarCalendar calendar)
        {
            _branches = calendar.GetBranches();
            _stems = calendar.GetStems();
            _sexagenary = calendar.GetSexagenary();
        }

        protected void Create()
        {
            Sexagenary = new SexagenaryDTO
            {
                Branch = _branches.FirstOrDefault(x => x.Id == BranchId), // new Branch(BranchId, _branches).BranchInfo,
                Stem = _stems.FirstOrDefault(x => x.Id == StemId), //new Stem(StemId, _stems).StemInfo,
                Dagua = SexagenaryRow.Dagua, //Token.Value<int>("dagua"),
                Period = SexagenaryRow.Period, //Token.Value<int>("period"),
                WuxingId = SexagenaryRow.WuxingId, //Token.Value<int>("wuxing_id")
            };
        }
    }
}
