using System;
using System.Collections.Generic;
using System.Globalization;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args )
        {
            var blackList = StopWords.ReadBlackListWords();

            var inputString = UIInput.EnterInputString();

            var splitList = Splitter.SplitString(inputString);

            var cleansedList = StopWords.ReturnCleansedString(blackList, splitList);

            var allWords = CountStrings.StringsCountFromList(cleansedList);

            var uniqueWords = CountStrings.UniqueStringsCountFromList(cleansedList);
            
            Console.WriteLine("number of words: " + allWords + ", unique: " + uniqueWords);

#if DEBUG
            Console.Read();
#endif
        }
    }
}