using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Data.Json;

namespace Data
{
    public class JsonCalendarRepository : ICalendarRepository
    {        

        public IEnumerable<Branch> GetBranches()
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(SexagenaryData.Branches);
            using MemoryStream stream = new MemoryStream(byteArray);
            return Utf8Json.JsonSerializer.Deserialize<IEnumerable<Branch>>(stream);            
        }

        public IEnumerable<Stem> GetStems()
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(SexagenaryData.Stems);
            using MemoryStream stream = new MemoryStream(byteArray);
            return Utf8Json.JsonSerializer.Deserialize<IEnumerable<Stem>>(stream);
        }

        public IEnumerable<Sexagenary> GetSexagenaries()
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(SexagenaryData.Sexagenary);
            using MemoryStream stream = new MemoryStream(byteArray);
            return Utf8Json.JsonSerializer.Deserialize<IEnumerable<Sexagenary>>(stream);
        }

        public Branch GetBranch(int id) => GetBranches().FirstOrDefault(x => x.Id == id);      

        public Stem GetStem(int id) => GetStems().FirstOrDefault(x => x.Id == id);        

        public Sexagenary GetSexagenary(int id) => GetSexagenaries().FirstOrDefault(x => x.Id == id);
        
        public void Dispose()
        {

        }
    }
}
