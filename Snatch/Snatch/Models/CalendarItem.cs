using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;

namespace Snatch.Models
{
    public class CalendarItem
    {
        public Stem Stem { get; set; }
        public Branch Branch { get; set; }
        public int Dagua { get; set; }
        public int Period { get; set; }
        public int WuxingId { get; set; }
    }
}
