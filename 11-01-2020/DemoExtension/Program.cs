using System;

namespace DemoExtension
{
    static class StringHelper
    {
        public static string FirstCaseChange(this String s)
        {
            char[] input = s.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? Char.ToLower(input[0]) : Char.ToUpper(input[0]);
         
            return new string(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome";
            string s=name.FirstCaseChange();
            Console.WriteLine(s);
            var a = new { property1 = "shree", property2 = 12, property3 = true };
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
} 
