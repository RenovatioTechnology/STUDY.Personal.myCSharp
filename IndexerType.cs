using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class IndexerType
    {
        // internal storage of string type array
        private string[] strArray = new string[10];
        // Let start with 
        public string this[int index]
        {
            get
            {
                if(index < 0 || index >= strArray.Length)
                    throw new ArgumentOutOfRangeException("index out of range");
                return strArray[index]; 
            }
            //Set the value
            set
            {
                if (index < 0 || index >= strArray.Length)
                    throw new ArgumentOutOfRangeException("Index out range");
                strArray[index] = value;    
            }
        }

    }
}
