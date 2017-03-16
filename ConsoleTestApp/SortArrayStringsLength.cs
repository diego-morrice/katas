using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    public class SortArrayStringsLength
    {
        public static string[] SortByLength(string[] array)
        {
            if(array == null || array.Length == 0)
                return  new string[0];

            return array.OrderBy(f => f.Length).ToArray();
        }
    }
}
