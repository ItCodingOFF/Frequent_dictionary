using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_17_Frequent_Dictionary
{
	class Program
	{
		static void Main(string[] args)
        {
            Console.Title = "Examen (Frequent Dictionary)";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("[ Enter path ]");
            string dirpath = Console.ReadLine();

            Frequent_Dictionary t = new Frequent_Dictionary(dirpath);
            Dictionary<string, int> v = t.ReadText();
            IOrderedEnumerable<KeyValuePair<string, int>> word = t.SortDescending(v);
            // t.SortDescending(v);
           // string word;
            Console.WriteLine("[ Enter path for file result ]");
            string savefile = Console.ReadLine();
			//string savefile;
			t.SaveToFile(word,savefile);
            //D:\WordsTEst
        }
	}
}
