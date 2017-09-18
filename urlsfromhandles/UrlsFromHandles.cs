using System;
using System.Collections.Generic;

namespace UrlsFromHandles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gitHubUrls = UrlsFromHandles(new List<string> { "ghhandle1", "ghhandle2" });

            for (int i = 0; i < gitHubUrls.Count; i++)
            {
                Console.WriteLine(gitHubUrls[i]);
            }
            Console.ReadLine();
        }

        private static List<string> UrlsFromHandles(List<string> list)
        {
            string insertText = "https://github.com/greenfox-academy/";

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = insertText + list[i];
            }
            return list;
        }
    }
}