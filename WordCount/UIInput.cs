using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordCount
{
    public static class UIInput
    {
        public static string EnterInputString()
        {
            Console.WriteLine("please enter a string: ");
            return Console.ReadLine();
        }

        public static string ProcessInput(string in_Arg)
        {
            if (in_Arg == "")
            {
                Console.WriteLine("enter new string to split: ");
                return Console.ReadLine();
            }
            else
            {
                string[] tmpArray = File.ReadAllLines(in_Arg);
                return string.Join(" ", tmpArray);
            }
        }
    }
}