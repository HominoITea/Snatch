using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public char Glyph { get; set; }
        public string Pinyin { get; set; }
        public string Transcription { get; set; }
        public string Ru { get; set; }
        public string En { get; set; }
        public int WuxingId { get; set; }
        public int YinYangId { get; set; }
        public double Degree { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public double EclipticStart { get; set; }
        public double EclipticEnd { get; set; }
    }
}
