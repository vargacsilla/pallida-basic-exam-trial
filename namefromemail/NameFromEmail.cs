using System;
using System.Text.RegularExpressions;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        private static string NameFromEmail(string email)
        {
            string[] names = email.Split(new Char[] { '.', '@' }); ;
            string name = names[0] + " " + names[1];
            return UpperFirst(name);
        }

        private static string UpperFirst(string name)
        {
            
        }
    }
}