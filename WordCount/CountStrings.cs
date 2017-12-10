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
            int result = 0;
            foreach (string word in in_List)
            {
                result++;
            }

            return result;
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

    }
}
