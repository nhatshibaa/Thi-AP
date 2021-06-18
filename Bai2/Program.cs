using System;
using System.Text.RegularExpressions;

namespace Bai2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str;
            string findStr;
            
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            findStr = Console.ReadLine();
            int times = Regex.Matches(str, findStr).Count;
            Console.Write("Word found " + times + " times in the string.");
        }
    }
}