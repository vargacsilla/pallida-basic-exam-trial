using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> Dictionary;

        static void Main(string[] args)
        {
            Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            Dictionary.Add("macska", "cat");
            AddWord("kutya", "dog");
            RemoveWord("alma");
            AddWord("kutya", "canine");
            AddWord("hajo", "ship");
            AddWord("boldog", "happy");

            foreach (KeyValuePair<string, string> item in Dictionary)
            {
                Console.WriteLine("Hungarian: {0} - English: {1}", item.Key, item.Value);
            }

            Console.WriteLine(TranslateToEnglish("fa"));

            Console.WriteLine(TranslateToHungarian("happy"));

            Console.ReadLine();
        }

        public static void AddWord(string hungarianWord, string englishWord)
        {
            if (Dictionary.ContainsKey(hungarianWord))
                return;
            else
                Dictionary.Add(hungarianWord, englishWord);
        }

        public static void RemoveWord(string hungarianWord)
        {
            Dictionary.Remove(hungarianWord);
        }

        public static string TranslateToEnglish(string hungarian)
        {
            return Dictionary[hungarian];
        }

        public static string TranslateToHungarian(string english)
        {
            string searchWord = "";
            foreach (KeyValuePair<string, string> item in Dictionary)
            {
                if (item.Value == english)
                    searchWord = item.Key;
            }
            return searchWord;
        }
    }
}