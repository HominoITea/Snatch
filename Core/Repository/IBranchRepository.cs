using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    interface IBranchRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetBranchList();
        T GetBranch(int id);
    }
}
