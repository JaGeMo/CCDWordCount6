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

            if (args.Length == 0)
            {
                args = new string[] { "" };
            }

            var inputString = UIInput.ProcessInput(args[0]);

            var splitList = Splitter.SplitString(inputString);

            var cleansedList = StopWords.ReturnCleansedString(blackList, splitList);

            var allWords = CountStrings.StringsCountFromList(cleansedList);

            var uniqueWords = CountStrings.UniqueStringsCountFromList(cleansedList);

            var averageDigitsPerWord = CountStrings.AverageNumberOfDigitsPerWord(cleansedList, allWords);

            var testFuncPointer = CountStrings.ReturnAverage(CountStrings.FuncPointer, cleansedList, allWords); // only for test purposes

            Console.WriteLine("number of words: " + allWords + ", unique: " + uniqueWords + ", average word length: " + averageDigitsPerWord.ToString(CultureInfo.GetCultureInfo("en-GB")));

#if DEBUG
            Console.Read();
#endif
        }
    }
}