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
    }
}