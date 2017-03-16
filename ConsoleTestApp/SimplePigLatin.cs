using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {

            if(string.IsNullOrEmpty(str))
                return str;

            var splitedStr = str.Split(' ').ToList();
            var result = splitedStr.Aggregate(string.Empty, (current, word) => current + (" " + word.Substring(1) + word[0] + "ay"));
            return result.Trim();
        }
    }
}
