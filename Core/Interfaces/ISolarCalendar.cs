using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface ISolarCalendar
    {
        public Branch[] GetBranches();
        public Stem[] GetStems();
        public Sexagenary[] GetSexagenary();
        public void GetData();

    }
}
