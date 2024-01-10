using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;

namespace Snatch.Models
{
    public readonly struct CalendarItem
    {
        public Stem Stem { get;  }
        public Branch Branch { get; }
        public int Dagua { get; }
        public int Period { get; }
        public int WuxingId { get; }

        public CalendarItem(Stem stem, Branch branch, int dagua, int period, int wuxingId)
        {
            Stem = stem;
            Branch = branch;
            Dagua = dagua;
            Period = period;
            WuxingId = wuxingId;
        }
    }
}
