using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    static class Calculate
    {
        static int count = 0;
        // no need for access modifier  can be access from outside
        static Calculate()
        {
            count = 0;
        }
        public static int increment()
        {
            count++;
            return count;
        }
        public static int decrement()
        {
            count--;
            return count;
        }

    }
}
