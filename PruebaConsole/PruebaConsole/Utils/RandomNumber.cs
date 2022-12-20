using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsole.Utils
{
    public static class RandomNumber
    {
        public static double NextDouble(double minimum, double maximum)
        {
            return new Random().NextDouble() * (maximum - minimum) + minimum;
        }

        public static double NextDesv(double number, double desv)
        {
            int sign = new Random().Next(100) < 70 ? 1 : -1;
            return number * (1 + sign * desv);
        }
    }
}
