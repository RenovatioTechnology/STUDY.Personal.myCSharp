using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    static class IntExtensions
    {
        public static bool IsGreaterThan(this int a, int value) 
        {
            return a > value;
        }
    }
}
