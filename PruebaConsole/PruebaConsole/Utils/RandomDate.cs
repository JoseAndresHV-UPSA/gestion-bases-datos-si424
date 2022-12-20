using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsole.Utils
{
    class RandomDate
    {
        DateTime _start;
        Random _gen;
        int _range;

        public RandomDate(DateTime start, DateTime end)
        {
            _start = start;
            _gen = new Random();
            _range = (end - start).Days;
        }

        public DateTime Next()
        {
            return _start.AddDays(_gen.Next(_range));
        }
    }
}
