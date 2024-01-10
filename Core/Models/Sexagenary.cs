using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public readonly struct Sexagenary
    {
        public int StemId { get; }
        public int BranchId { get; }
        public int Dagua { get; }
        public int Period { get; }
        public int WuxingId { get; }

        public Sexagenary(int stemId, int branchId, int dagua, int period, int wuxingId)
        {
            StemId = stemId;
            BranchId = branchId;
            Dagua = dagua;
            Period = period;
            WuxingId = wuxingId;
        }
    }
}
