using System;
using System.Text.RegularExpressions;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        private static string NameFromEmail(string email)
        {
            string[] names = email.Split(new Char[] { '.', '@' }); ;
            string name = UpperFirst(names[0]) + " " + UpperFirst(names[1]);
            return name;
        }

        private static string UpperFirst(string name)
        {
            var chars = name.ToCharArray();
            name = char.ToUpper(chars[0]) + name.Substring(1);
            return name;
        }
    }
}