using System;

public class Class1
{
    public static class StopWords
    {
        private static string[] blackList;

        public static string[] ReadBlackListWords()
        {
            string path = @"c:\temp\MyTest.txt";

            if (File.Exists(path))
            {
                blackList = File.ReadAllLines(path);
            }
            else
            {
                Console.WriteLine("file not found .. ");
            }

            return blackList;
        }

        public static List<string> ReturnCleansedString(string[] in_Blacklist, List<string> in_RawStringList)
        {
            foreach (string blackListString in blackList)
            {
                if (in_RawStringList.Any(s => s.Contains(blackListString)))
                {
                    in_RawStringList.Remove(blackListString);
                    // cleansedStringList.Remove(blackListString);
                }
            }

            return in_RawStringList;
        }
    }
}
