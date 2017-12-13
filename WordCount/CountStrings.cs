using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public static class CountStrings
    {
        
        public static int StringsCountFromList(List<string> in_List)
        {
            int counterItems = 0;

            foreach (string word in in_List)
            {
                counterItems++;
            }

            return counterItems;
        }

        public static int UniqueStringsCountFromList(List<string> in_List)
        {
            int counterUniqueItems = 1;

            in_List.Sort();

            for (int i = 1; i < in_List.Count; i++ )
            {
                if (in_List[i-1] != in_List[i])
                {
                    counterUniqueItems++;
                }
            }

            return counterUniqueItems;
        }

        public static double AverageNumberOfDigitsPerWord(List<string> in_List, int countedStrings)
        {
            int sumDigits = 0;

            foreach (string word in in_List)
            {
                sumDigits += word.Length;
            }

            //Console.WriteLine(sumDigits.ToString());
            return (double)sumDigits / countedStrings;
        }

        public static double ReturnAverage(Func<List<string>, int, double> func, List<string> in_List, int in_Int)
        {
            return func(in_List, in_Int);
        }

        public static Func<List<string>, int, double> FuncPointer = AverageNumberOfDigitsPerWord;
    }
}
