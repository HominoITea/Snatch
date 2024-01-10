using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public readonly struct Stem
    {
        public int Id { get; }
        public char Glyph { get; }
        public string Pinyin { get; }
        public string Transcription { get; }
        public int WuxingId { get; }
        public int YinYangId { get; }
        public int DirectionId { get;  }
        public int MonthKey { get; }
        public int HourKey { get; }

        public Stem(int id, char glyph, string pinyin, string transcription, int wuxingId, int yinYangId, int directionId, int monthKey, int hourKey)
        {
            Id = id;
            Glyph = glyph;
            Pinyin = pinyin;
            Transcription = transcription;
            WuxingId = wuxingId;
            YinYangId = yinYangId;
            DirectionId = directionId;
            MonthKey = monthKey;
            HourKey = hourKey;
        }


    }
}
