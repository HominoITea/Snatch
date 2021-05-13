using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Stem
    {
        public int Id { get; set; }
        public char Glyph { get; set; }
        public string Pinyin { get; set; }
        public string Transcription { get; set; }
        public int WuxingId { get; set; }
        public int YinYangId { get; set; }
        public double DirectionId { get; set; }
        public int MonthKey { get; set; }
        public int HourKey { get; set; }
    }
}
