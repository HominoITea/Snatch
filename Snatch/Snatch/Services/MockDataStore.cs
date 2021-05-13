using Snatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snatch.Services
{
    public class MockDataStore : ICalendarStore<CalendarItem>
    {
        readonly List<CalendarItem> items;

        public MockDataStore()
        {
            //items = new List<CalendarItem>()
            //{
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            //};
        }

        public async Task<bool> AddItemAsync(CalendarItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CalendarItem item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

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