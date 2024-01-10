using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public readonly struct Branch
    {
        public int Id { get; }
        public char Glyph { get; }
        public string Pinyin { get; }
        public string Transcription { get; }
        public string Ru { get; }
        public string En { get; }
        public int WuxingId { get; }
        public int YinYangId { get; }
        public double Degree { get; }
        public int StartHour { get; }
        public int EndHour { get; }
        public double EclipticStart { get; }
        public double EclipticEnd { get; }

        public Branch(int id, char glyph, string pinyin, string transcription, string ru, string en, int wuxingId, int yinYangId, double degree, int startHour, int endHour, double eclipticStart, double eclipticEnd)
        {
            Id = id;
            Glyph = glyph;
            Pinyin = pinyin;
            Transcription = transcription;
            Ru = ru;
            En = en;
            WuxingId = wuxingId;
            YinYangId = yinYangId;
            Degree = degree;
            StartHour = startHour;
            EndHour = endHour;
            EclipticStart = eclipticStart;
            EclipticEnd = eclipticEnd;
        }
    }
}
