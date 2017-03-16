using System.Collections.Generic;
using System.Linq;


namespace Codes
{
    public class NextBiggerNumberKata
    {
        public static long NextBiggerNumber(long n)
        {
            var nextNumber = n;
            var numberSplited = n.ToString().ToList();
            List<long> numberCheck = numberSplited.Select(s => long.Parse(s.ToString())).OrderByDescending(f => f).ToList();

            if (numberSplited.Select(s => long.Parse(s.ToString())).SequenceEqual(numberCheck) && n.ToString().SequenceEqual(n.ToString()))
                return -1;

            while (true)
            {
                nextNumber++;

                if (Finder(new List<char>(numberSplited), nextNumber.ToString()))
                    break;
            }

            return nextNumber;
        }

        public static bool Finder(List<char> validator, string number)
        {

            foreach (var t in number)
            {
                if (!validator.Contains(t))
                    return false;

                validator.Remove(t);
            }

            return true;
        }
    }
}
