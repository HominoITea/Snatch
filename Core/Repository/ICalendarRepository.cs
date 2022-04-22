using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    public interface ICalendarRepository : IDisposable
    {
        IEnumerable<Branch> GetBranches();
        IEnumerable<Stem> GetStems();
        IEnumerable<Sexagenary> GetSexagenaries();
        Branch GetBranch(int id);
        Stem GetStem(int id);
        Sexagenary GetSexagenary(int id);
        //void Create(T item); // создание объекта
        //void Update(T item); // обновление объекта
        //void Delete(int id); // удаление объекта по id
        //void Save();  // сохранение изменений
    }
}
