using Snatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;

namespace Snatch.Services
{
    public class MockDataStore : ICalendarStore<CalendarItem>
    {
        readonly CalendarItem[] items;

        public MockDataStore()
        {
            items = new CalendarItem[365];
            items[0] = new CalendarItem
            {
                Stem = new Stem(id: 1, glyph: '甲', pinyin: "jiă", transcription: "Цзя", wuxingId: 1, yinYangId: 1,
                    directionId: 1, monthKey: 3, hourKey: 1),
                Branch = new Branch(id: 1, glyph: '子', pinyin: "zǐ", transcription: "Цзы", ru: "Крыса", en: "Rat",
                    wuxingId: 5, yinYangId: 1, degree: 0, startHour: 23, endHour: 0, eclipticStart: 255,
                    eclipticEnd: 284.9999
                ),
                Dagua = 1,
                Period = 1,
                WuxingId = 5
            };
        }

        //public async Task<bool> AddItemAsync(CalendarItem item)
        //{
        //    items.Add(item);

        //    return await Task.FromResult(true);
        //}

        //public async Task<bool> UpdateItemAsync(CalendarItem item)
        //{
        //    var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
        //    items.Remove(oldItem);
        //    items.Add(item);

        //    return await Task.FromResult(true);
        //}

        //public async Task<bool> DeleteItemAsync(string id)
        //{
        //    var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
        //    items.Remove(oldItem);

        //    return await Task.FromResult(true);
        //}

        public async Task<CalendarItem> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s. == id));
        }

        public async Task<IEnumerable<CalendarItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}