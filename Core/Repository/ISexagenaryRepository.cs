using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    interface ISexagenaryRepository<T> : IDisposable where T: class
    {
        IEnumerable<T> GetSexagenaryList();
        T GetSexagenary(int id);
    }
}
