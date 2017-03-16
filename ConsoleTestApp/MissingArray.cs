using System.Linq;


namespace Codes
{
    public class MissingArray
    {
        public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            if (arrayOfArrays == null || arrayOfArrays.Length < 0 || arrayOfArrays.Any(f => f == null || f.Length <= 0))
                return 0;

            arrayOfArrays = arrayOfArrays.OrderBy(f => f.Length).ToArray();

            var previousArrayLength = 0;
            foreach (object[] t in arrayOfArrays)
            {
                if (previousArrayLength == 0)
                {
                    previousArrayLength = t.Length;
                    continue;
                }

                if (t.Length > (previousArrayLength + 1))
                    return (previousArrayLength + 1);

                previousArrayLength = t.Length;
            }

            return 0;
        }
    }
}
