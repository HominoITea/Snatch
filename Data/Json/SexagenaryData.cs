
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Json
{

	public static class SexagenaryData
	{
		public static string Stems
		{
			get
			{
				return "[" +
"{ \"Id\": 1, \"Glyph\": \"甲\", \"Pinyin\": \"jiă\", \"Transcription\": \"Цзя\", \"WuxingId\": 1, \"YinYangId\": 1, \"DirectionId\": 1, \"MonthKey\": 3, \"HourKey\": 1}," +
"{ \"Id\": 2, \"Glyph\": \"乙\", \"Pinyin\": \"yǐ\", \"Transcription\": \"И\", \"WuxingId\": 1, \"YinYangId\": 2, \"DirectionId\": 1, \"MonthKey\": 5, \"HourKey\": 3 }," +
"{ \"Id\": 3, \"Glyph\": \"丙\", \"Pinyin\": \"bǐng\", \"Transcription\": \"Бин\", \"WuxingId\": 2, \"YinYangId\": 1, \"DirectionId\": 2, \"MonthKey\": 7, \"HourKey\": 5 }," +
"{ \"Id\": 4, \"Glyph\": \"丁\", \"Pinyin\": \"dīng\", \"Transcription\": \"Дин\", \"WuxingId\": 2, \"YinYangId\": 2, \"DirectionId\": 2, \"MonthKey\": 9, \"HourKey\": 7 }," +
"{ \"Id\": 5, \"Glyph\": \"戊\", \"Pinyin\": \"wù\", \"Transcription\": \"У\", \"WuxingId\": 3, \"YinYangId\": 1, \"DirectionId\": 3, \"MonthKey\": 1, \"HourKey\": 9 }," +
"{ \"Id\": 6, \"Glyph\": \"己\", \"Pinyin\": \"jǐ\", \"Transcription\": \"Цзи\", \"WuxingId\": 3, \"YinYangId\": 2, \"DirectionId\": 3, \"MonthKey\": 3, \"HourKey\": 1 }," +
"{ \"Id\": 7, \"Glyph\": \"庚\", \"Pinyin\": \"gēng\", \"Transcription\": \"Гэн\", \"WuxingId\": 4, \"YinYangId\": 1, \"DirectionId\": 4, \"MonthKey\": 5, \"HourKey\": 3 }," +
"{ \"Id\": 8, \"Glyph\": \"辛\", \"Pinyin\": \"xīn\", \"Transcription\": \"Син\", \"WuxingId\": 4, \"YinYangId\": 2, \"DirectionId\": 4, \"MonthKey\": 7, \"HourKey\": 5 }," +
"{ \"Id\": 9, \"Glyph\": \"壬\", \"Pinyin\": \"rén\", \"Transcription\": \"Рен\", \"WuxingId\": 5, \"YinYangId\": 1, \"DirectionId\": 5, \"MonthKey\": 9, \"HourKey\": 7 }," +
"{ \"Id\": 10, \"Glyph\": \"癸\", \"Pinyin\": \"guǐ\", \"Transcription\": \"Гуй\", \"WuxingId\": 5, \"YinYangId\": 2, \"DirectionId\": 5, \"MonthKey\": 1, \"HourKey\": 9 }" +
"]";
			}
		}
		public static string Branches
		{
			get
			{
				return "[" +
"{ \"Id\": 1, \"Glyph\": \"子\", \"Pinyin\": \"zǐ\", \"Transcription\": \"Цзы\", \"Ru\": \"Крыса\", \"En\": \"Rat\", \"WuxingId\": 5, \"YinYangId\": 1, \"Degree\": 0, \"StartHour\":  23, \"EndHour\":  0, \"EclipticStart\": 255, \"EclipticEnd\": 284.9999}," +
"{ \"Id\": 2, \"Glyph\": \"丑\", \"Pinyin\": \"chǒu\", \"Transcription\": \"Чоу\", \"Ru\": \"Бык\", \"En\": \"Ox\", \"WuxingId\": 3, \"YinYangId\": 2, \"Degree\": 30, \"StartHour\":  1, \"EndHour\":  2, \"EclipticStart\":  285, \"EclipticEnd\": 314.9999}," +
"{\"Id\": 3, \"Glyph\": \"寅\", \"Pinyin\": \"yín\", \"Transcription\": \"Инь\", \"Ru\": \"Тигр\", \"En\": \"Tiger\", \"WuxingId\": 1, \"YinYangId\": 1, \"Degree\": 60, \"StartHour\":  3, \"EndHour\":  4 , \"EclipticStart\": 315, \"EclipticEnd\": 344.9999}," +
"{ \"Id\": 4, \"Glyph\": \"卯\", \"Pinyin\": \"mǎo\", \"Transcription\": \"Мао\", \"Ru\": \"Заяц\", \"En\": \"Rabbit\", \"WuxingId\": 1, \"YinYangId\": 2, \"Degree\": 90, \"StartHour\":  5, \"EndHour\":  6,  \"EclipticStart\": 345, \"EclipticEnd\": 14.9999}," +
"{ \"Id\": 5, \"Glyph\": \"辰\", \"Pinyin\": \"chén\", \"Transcription\": \"Чэнь\", \"Ru\": \"Дракон\", \"En\": \"Dragon\", \"WuxingId\": 3, \"YinYangId\": 1, \"Degree\": 120, \"StartHour\":  7, \"EndHour\":  8, \"EclipticStart\": 15, \"EclipticEnd\": 44.9999}," +
"{ \"Id\": 6, \"Glyph\": \"巳\", \"Pinyin\": \"sì\", \"Transcription\": \"Сы\", \"Ru\": \"Змея\", \"En\": \"Snake\", \"WuxingId\": 2, \"YinYangId\": 2, \"Degree\": 150, \"StartHour\":  9, \"EndHour\":  10,  \"EclipticStart\": 45, \"EclipticEnd\": 74.9999}," +
"{ \"Id\": 7, \"Glyph\": \"午\", \"Pinyin\": \"wǔ\", \"Transcription\": \"У\", \"Ru\": \"Лошадь\", \"En\": \"Horse\", \"WuxingId\": 2, \"YinYangId\": 1, \"Degree\": 180, \"StartHour\":  11, \"EndHour\":  12,  \"EclipticStart\": 75, \"EclipticEnd\": 104.9999}," +
"{ \"Id\": 8, \"Glyph\": \"未\", \"Pinyin\": \"wèi\", \"Transcription\": \"Вэй\", \"Ru\": \"Коза\", \"En\": \"Goat\", \"WuxingId\": 3, \"YinYangId\": 2, \"Degree\": 210, \"StartHour\":  13, \"EndHour\":  14, \"EclipticStart\": 105, \"EclipticEnd\": 134.9999}," +
"{ \"Id\": 9, \"Glyph\": \"申\", \"Pinyin\": \"shēn\", \"Transcription\": \"Шэнь\", \"Ru\": \"Обезьяна\", \"En\": \"Monkey\", \"WuxingId\": 4, \"YinYangId\": 1, \"Degree\": 240, \"StartHour\":  15, \"EndHour\":  16, \"EclipticStart\": 135, \"EclipticEnd\": 164.9999}," +
"{ \"Id\": 10, \"Glyph\": \"酉\", \"Pinyin\": \"yǒu\", \"Transcription\": \"Ю\", \"Ru\": \"Петух\", \"En\": \"Roaster\", \"WuxingId\": 4, \"YinYangId\": 2, \"Degree\": 270, \"StartHour\":  17, \"EndHour\":  18, \"EclipticStart\": 165, \"EclipticEnd\": 194.9999}," +
"{ \"Id\": 11, \"Glyph\": \"戌\", \"Pinyin\": \"xū\", \"Transcription\": \"Сюй\", \"Ru\": \"Собака\", \"En\": \"Dog\", \"WuxingId\": 3, \"YinYangId\": 1, \"Degree\": 300, \"StartHour\":  19, \"EndHour\":  20,  \"EclipticStart\": 195, \"EclipticEnd\": 224.9999}," +
"{ \"Id\": 12, \"Glyph\": \"亥\", \"Pinyin\": \"hài\", \"Transcription\": \"Хай\", \"Ru\": \"Свинья\", \"En\": \"Pig\", \"WuxingId\": 5, \"YinYangId\": 2, \"Degree\": 330, \"StartHour\":  21, \"EndHour\":  22,  \"EclipticStart\": 225, \"EclipticEnd\": 254.9999}" +
"]";
			}
		}
		public static string Sexagenary
		{
			get
			{
				return "[" +
"{ \"StemId\": 1, \"BranchId\": 1, \"Dagua\": 1, \"Period\": 1, \"WuxingId\": 5 }," +
"{ \"StemId\": 2, \"BranchId\": 2, \"Dagua\": 3, \"Period\": 6, \"WuxingId\": 1 }," +
"{ \"StemId\": 3, \"BranchId\": 3, \"Dagua\": 2, \"Period\": 4, \"WuxingId\": 2 }," +
"{ \"StemId\": 4, \"BranchId\": 4, \"Dagua\": 6, \"Period\": 9, \"WuxingId\": 5 }," +
"{ \"StemId\": 5, \"BranchId\": 5, \"Dagua\": 9, \"Period\": 6, \"WuxingId\": 4 }," +
"{ \"StemId\": 6, \"BranchId\": 6, \"Dagua\": 3, \"Period\": 2, \"WuxingId\": 1 }," +
"{ \"StemId\": 7, \"BranchId\": 7, \"Dagua\": 8, \"Period\": 9, \"WuxingId\": 1 }," +
"{ \"StemId\": 8, \"BranchId\": 8, \"Dagua\": 9, \"Period\": 3, \"WuxingId\": 4 }," +
"{ \"StemId\": 9, \"BranchId\": 9, \"Dagua\": 1, \"Period\": 7, \"WuxingId\": 5 }," +
"{ \"StemId\": 10, \"BranchId\": 10, \"Dagua\": 2, \"Period\": 7, \"WuxingId\": 2 }," +
"{ \"StemId\": 1, \"BranchId\": 11, \"Dagua\": 7, \"Period\": 2, \"WuxingId\": 2 }," +
"{ \"StemId\": 2, \"BranchId\": 12, \"Dagua\": 3, \"Period\": 3, \"WuxingId\": 1 }," +
"{ \"StemId\": 3, \"BranchId\": 1, \"Dagua\": 6, \"Period\": 3, \"WuxingId\": 5 }," +
"{ \"StemId\": 4, \"BranchId\": 2, \"Dagua\": 4, \"Period\": 7, \"WuxingId\": 4 }," +
"{ \"StemId\": 5, \"BranchId\": 3, \"Dagua\": 8, \"Period\": 6, \"WuxingId\": 1 }," +
"{ \"StemId\": 6, \"BranchId\": 4, \"Dagua\": 7, \"Period\": 8, \"WuxingId\": 2 }," +
"{ \"StemId\": 7, \"BranchId\": 5, \"Dagua\": 1, \"Period\": 9, \"WuxingId\": 5 }," +
"{ \"StemId\": 8, \"BranchId\": 6, \"Dagua\": 3, \"Period\": 7, \"WuxingId\": 1 }," +
"{ \"StemId\": 9, \"BranchId\": 7, \"Dagua\": 2, \"Period\": 1, \"WuxingId\": 2 }," +
"{ \"StemId\": 10, \"BranchId\": 8, \"Dagua\": 4, \"Period\": 8, \"WuxingId\": 4 }," +
"{ \"StemId\": 1, \"BranchId\": 9, \"Dagua\": 3, \"Period\": 9, \"WuxingId\": 1 }," +
"{ \"StemId\": 2, \"BranchId\": 10, \"Dagua\": 9, \"Period\": 4, \"WuxingId\": 4 }," +
"{ \"StemId\": 3, \"BranchId\": 11, \"Dagua\": 6, \"Period\": 1, \"WuxingId\": 5 }," +
"{ \"StemId\": 4, \"BranchId\": 12, \"Dagua\": 8, \"Period\": 8, \"WuxingId\": 1 }," +
"{ \"StemId\": 5, \"BranchId\": 1, \"Dagua\": 7, \"Period\": 4, \"WuxingId\": 2 }," +
"{ \"StemId\": 6, \"BranchId\": 2, \"Dagua\": 9, \"Period\": 2, \"WuxingId\": 4 }," +
"{ \"StemId\": 7, \"BranchId\": 3, \"Dagua\": 3, \"Period\": 1, \"WuxingId\": 1 }," +
"{ \"StemId\": 8, \"BranchId\": 4, \"Dagua\": 2, \"Period\": 3, \"WuxingId\": 2 }," +
"{ \"StemId\": 9, \"BranchId\": 5, \"Dagua\": 6, \"Period\": 4, \"WuxingId\": 5 }," +
"{ \"StemId\": 10, \"BranchId\": 6, \"Dagua\": 4, \"Period\": 6, \"WuxingId\": 4 }," +
"{ \"StemId\": 1, \"BranchId\": 7, \"Dagua\": 9, \"Period\": 1, \"WuxingId\": 4 }," +
"{ \"StemId\": 2, \"BranchId\": 8, \"Dagua\": 7, \"Period\": 6, \"WuxingId\": 2 }," +
"{ \"StemId\": 3, \"BranchId\": 9, \"Dagua\": 8, \"Period\": 4, \"WuxingId\": 1 }," +
"{ \"StemId\": 4, \"BranchId\": 10, \"Dagua\": 4, \"Period\": 9, \"WuxingId\": 4 }," +
"{ \"StemId\": 5, \"BranchId\": 11, \"Dagua\": 1, \"Period\": 6, \"WuxingId\": 5 }," +
"{ \"StemId\": 6, \"BranchId\": 12, \"Dagua\": 2, \"Period\": 2, \"WuxingId\": 2 }," +
"{ \"StemId\": 7, \"BranchId\": 1, \"Dagua\": 2, \"Period\": 9, \"WuxingId\": 2 }," +
"{ \"StemId\": 8, \"BranchId\": 2, \"Dagua\": 1, \"Period\": 3, \"WuxingId\": 5 }," +
"{ \"StemId\": 9, \"BranchId\": 3, \"Dagua\": 9, \"Period\": 7, \"WuxingId\": 4 }," +
"{ \"StemId\": 10, \"BranchId\": 4, \"Dagua\": 8, \"Period\": 7, \"WuxingId\": 1 }," +
"{ \"StemId\": 1, \"BranchId\": 5, \"Dagua\": 3, \"Period\": 2, \"WuxingId\": 1 }," +
"{ \"StemId\": 2, \"BranchId\": 6, \"Dagua\": 7, \"Period\": 3, \"WuxingId\": 2 }," +
"{ \"StemId\": 3, \"BranchId\": 7, \"Dagua\": 4, \"Period\": 3, \"WuxingId\": 4 }," +
"{ \"StemId\": 4, \"BranchId\": 8, \"Dagua\": 6, \"Period\": 7, \"WuxingId\": 5 }," +
"{ \"StemId\": 5, \"BranchId\": 9, \"Dagua\": 2, \"Period\": 6, \"WuxingId\": 2 }," +
"{ \"StemId\": 6, \"BranchId\": 10, \"Dagua\": 3, \"Period\": 8, \"WuxingId\": 1 }," +
"{ \"StemId\": 7, \"BranchId\": 11, \"Dagua\": 9, \"Period\": 9, \"WuxingId\": 4 }," +
"{ \"StemId\": 8, \"BranchId\": 12, \"Dagua\": 7, \"Period\": 7, \"WuxingId\": 2 }," +
"{ \"StemId\": 9, \"BranchId\": 1, \"Dagua\": 8, \"Period\": 1, \"WuxingId\": 1 }," +
"{ \"StemId\": 10, \"BranchId\": 2, \"Dagua\": 6, \"Period\": 8, \"WuxingId\": 5 }, " +
"{ \"StemId\": 1, \"BranchId\": 3, \"Dagua\": 7, \"Period\": 9, \"WuxingId\": 2 }," +
"{ \"StemId\": 2, \"BranchId\": 4, \"Dagua\": 1, \"Period\": 4, \"WuxingId\": 5 }," +
"{ \"StemId\": 3, \"BranchId\": 5, \"Dagua\": 4, \"Period\": 1, \"WuxingId\": 4 }," +
"{ \"StemId\": 4, \"BranchId\": 6, \"Dagua\": 2, \"Period\": 8, \"WuxingId\": 2 }," +
"{ \"StemId\": 5, \"BranchId\": 7, \"Dagua\": 3, \"Period\": 4, \"WuxingId\": 1 }," +
"{ \"StemId\": 6, \"BranchId\": 8, \"Dagua\": 1, \"Period\": 2, \"WuxingId\": 5 }," +
"{ \"StemId\": 7, \"BranchId\": 9, \"Dagua\": 7, \"Period\": 1, \"WuxingId\": 2 }," +
"{ \"StemId\": 8, \"BranchId\": 10, \"Dagua\": 8, \"Period\": 3, \"WuxingId\": 1 }," +
"{ \"StemId\": 9, \"BranchId\": 11, \"Dagua\": 4, \"Period\": 4, \"WuxingId\": 4 }," +
"{ \"StemId\": 10, \"BranchId\": 12, \"Dagua\": 6, \"Period\": 6, \"WuxingId\": 5 }" +
"]";
			}
		}
	}
}
