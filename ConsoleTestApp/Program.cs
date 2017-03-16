using System;
using System.Collections.Generic;
using System.Linq;

namespace Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { -1, 3, -4, 5, 1, -6, 2, 1 };

            //      var expected = new int[,]
            //{{1,4,3},
            // {1,4,4},
            // {2,3,4}};

            //var actual = new int[,]
            //    {{1, 2, 3}, 
            //    {1, 2, 2}, 
            //    {2, 3, 2}};

            //var actual = new int[,]
            //{
            //    {2, 3, 2, 4, 5, 2},
            //    {2, 8, 2, 2, 3, 2},
            //    {13, 14, 2, 2, 17, 18}
            //};

            //var actual = new int[,]
            //{
            //    {13, 14, 2, 2, 17, 18}
            //};


            //var teste = FloodFill(actual, 0, 0, 4);

            //for (int i = 0; i < teste.GetLength(0); i++)
            //{
            //    for (int j = 0; j < teste.GetLength(1); j++)
            //    {
            //     Console.Write(teste[i,j] + ",");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(exec(test));


            //Console.WriteLine(SumDigPow(1, 10));
            //Console.WriteLine(SumDigPow(1, 100));
            //Console.WriteLine(SumDigPow(90, 150));
            //Console.WriteLine(multiply(30, "tfoda"));

            //Console.WriteLine(StringBrackets("(())"));
            //Console.WriteLine(StringBrackets("(())))("));
            //Console.WriteLine(StringBrackets("))"));
            //Console.WriteLine(StringBrackets("((((())()())))"));

            //Console.WriteLine(ChessGame(4, 5));
            //Console.WriteLine(ChessGame(1, 0));
            //Console.WriteLine(ChessGame(6, 6));
            //Console.WriteLine(ChessGame(0, 2));
            //Console.WriteLine(ChessGame(2, 0));
            //Console.WriteLine(ChessGame(2, 1));
            //Console.WriteLine(ChessGame(1, 2));

            //int[] test1 = new int[] {1, 0, 0, 1, 1};
            //Console.WriteLine(BitsTest(test));

            //string[] test2 = { "Telescopes", "Glasses", "Eyes", "Monocles"};
            //test2 = SortArrayStringsLength.SortByLength(test2);

            //for (int i = 0; i < test2.Length; i++)
            //{
            //    Console.WriteLine(test2[i]);
            //}

            //Console.WriteLine(MoneyInvest.CalculateYears(1000, 0.05, 0.18, 1100));

            //FindShort("bitcoin take over the world maybe who knows perhaps");

            //IsAmolstPalindrome("abccba");
            //IsAmolstPalindrome("abccbx");

            int[] test1 = new int[] {  34,31, 34, 77,82 };
            int[] test2 = new int[] { 14, 14, 2342, 2342, 2342};
            int[] test3 = new int[] { 14, 14, 2342, 2342, 2342, 14, 17, 88 };

            MostPopularNumber(test1, 5);
            MostPopularNumber(test2, 5);
            MostPopularNumber(test3, 8);


            Console.ReadKey();
        }

        public static int exec(int[] A)
        {
            if (A == null || A.Length == 0)
                return -1;

            for (int i = 0; i < A.Length; i++)
            {
                long othersHigherTotal = 0;
                long othersLowerTotal = 0;

                for (int y = i + 1; y < A.Length; y++)
                    othersHigherTotal += A[y];

                for (int w = i - 1; w >= 0; w--)
                    othersLowerTotal += A[w];

                if (othersLowerTotal == othersHigherTotal)
                    return i;
            }

            return -1;
        }

        public static int multiply(int a, string b)
        {
            int number;
            if (int.TryParse(b, out number))
            {
                return a * number;
            }

            return 0;
        }

        public double[] Tribonacci(double[] signature, int n)
        {
            double[] empty = { 0 };
            double[] tribonacci = new double[n];

            if (n == 0)
                return empty;

            if (signature == null || signature.Length == 0)
                return signature;

            if (n <= signature.Length)
                for (int i = 0; i < tribonacci.Length; i++)
                    tribonacci[i] = signature[i];

            else
                for (int i = 0; i < signature.Length; i++)
                    tribonacci[i] = signature[i];

            for (int i = 3; i < n; i++)
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];

            return tribonacci;
        }

        public static long[] SumDigPow(long a, long b)
        {
            var result = new List<long>();
            long higher = a > b ? a : b;
            long lower = a < b ? a : b;

            for (long i = lower; i <= higher; i++)
            {
                List<long> values = new List<long>();

                if (i < 10)
                    values.Add(i);
                else
                    for (int y = 0; y < i.ToString().Length; y++)
                        values.Add(Convert.ToInt32(i.ToString()[y].ToString()));

                if (i == RetunrPowValue(values))
                    result.Add(i);
            }

            return result.OrderBy(f => f).ToArray();
        }

        private static long RetunrPowValue(List<long> values)
        {
            if (values == null || values.Count == 0)
                return 0;

            List<double> powValues = new List<double>();

            for (int i = 0; i < values.Count; i++)
                powValues.Add(Math.Pow(values[i], (i + 1)));

            return Convert.ToInt64(powValues.Sum());
        }

        public static int[,] FloodFill(int[,] array, int x, int y, int newValue)
        {
            if (array == null || array.Length == 0)
                return array;

            int[,] newArray = (int[,])array.Clone();

            var oldValue = array[x, y];
            newArray[x, y] = newValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == oldValue)
                        if (AnyOtherNear(array, i, j))
                            newArray[i, j] = newValue;
                }
            }

            return newArray;
        }

        private static bool AnyOtherNear(int[,] array, int x, int y)
        {
            int searchValue = array[x, y];

            //vertical matching
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (i > array.GetUpperBound(0))
                    break;

                if (i == x)
                    continue;

                if ((i == (x + 1) || i == (x - 1)) && array[i, y] == searchValue)
                    return true;
            }

            //horizontal matching
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i > array.GetUpperBound(1))
                    break;

                if (i == y)
                    continue;

                if ((i == (y + 1) || i == (y - 1)) && array[x, i] == searchValue)
                    return true;
            }

            return false;
        }

        public static int StringBrackets(string S)
        {
            if (string.IsNullOrEmpty(S))
                return 0;

            List<int> numberOpenining = new List<int>();
            List<int> numberClosing = new List<int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    numberOpenining.Add(i);
                else
                    numberClosing.Add(i);
            }
            if (numberClosing.Count == numberOpenining.Count)
                return S.Length / 2;

            if (numberClosing.Count == 0)
                return numberOpenining.Count;

            if (numberOpenining.Count == 0)
                return numberClosing.Count;

            return numberClosing.Count > numberOpenining.Count ? numberClosing.Count : numberOpenining.Count;

            return S.Length % 2;
        }

        public static int ChessGame(int A, int B)
        {
            if (((A + B) / 3 <= 0))
            {
                if (A == 2)
                    return A;

                if (B == 2)
                    return B;

                return 3;
            }


            if (((A + B) / 3) >= 100000000)
                return -2;

            return (A + B) / 3;
        }

        public static int[] BitsTest(int[] A)
        {
            if (A == null)
                return new int[0];
            ;


            string temp = string.Empty;

            for (int i = 0; i < A.Length; i++)
            {
                //temp += A[i].ToString().Remove("-", "");
            }

            int number = Convert.ToInt32(temp, 2);

            var temp2 = System.Math.Abs(-number).ToString();

            int[] result = new int[] { };

            for (int i = 0; i < temp2.Length; i++)
            {
                result[i] = temp2[i];
            }
            return result;
        }

        public static int FindShort(string s)
        {
            int result = 0;
            List<string> wordList = s.Split(' ').ToList();
            foreach (var word in wordList)
            {
                if (result == 0)
                    result = word.Length;

                if (result > word.Length)
                    result = word.Length;
            }
            return result;
        }

        public static double AVG(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            var dist1 = Hypot(x1 - x2, y1 - y2);
            var dist2 = Hypot(x1 - x3, y1 - y3);
            var dist3 = Hypot(x2 - x3, y2 - y3);

            return (dist1 + dist2 + dist3) / 3;

        }

        public static double Hypot(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }



        public static bool IsAmolstPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            bool oneMistake = false;

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    if (!oneMistake)
                        oneMistake = true;
                    else
                        return false;
                }

                i++;
                j--;
            }

            return true;
        }




        public static int MostPopularNumber(int[] a, int length)
        {
            var count = 0;
            var popular = a[0];
            for (var i = 0; i < (length - 1); i++)
            {
                var temp = a[i];
                var tempCount = 0;
                for (var j = 0; j < length; j++)
                {
                    if (temp == a[j])
                        tempCount++;
                }

                if (tempCount < count) continue;

                if (tempCount == count && temp > popular) continue;

                popular = temp;
                count = tempCount;

            }

            return popular;
        }
    }
}