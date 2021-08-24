using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_17_Frequent_Dictionary
{
	class Frequent_Dictionary
	{
        Dictionary<string, int> words = new Dictionary<string, int>();
        string dirpath; string[] files;
        

        public Frequent_Dictionary(string path)
        {
            this.dirpath = path;
            this.files = Directory.GetFiles(this.dirpath);
        }

        public Dictionary<string, int> ReadText()
        {

            char[] symbols = { ' ', ',', '.', '!', '?', ':', '"', '*', '(', ')', '$', '`', '^', '%' };
            foreach (var item in files)
            {
                if (item.Contains(".txt"))
                {
                    string[] word1 = File.ReadAllLines(item);
                    foreach (string t in word1)
                    {
                        string[] word2 = t.Split(symbols);
                        foreach (var item1 in word2)
                        {
                            if (words.ContainsKey(item1))
                            {
                                words[item1]++;
                            }
                            else
                            {
                                words.Add(item1, 1);
                            }
                        }
                    }
                }

            }
            return this.words;
        }
		//Dictionary<string, int> dictionary = new Dictionary<string, int>();

		//public int OnEvent(HashSet<string> files)
		//{

		//    foreach (var item in files)
		//    {

		//        string[] words = File.ReadAllLines(item);
		//        foreach (var item1 in words)
		//        {
		//            Regex regex = new Regex(@"\w*(( )|(,)|(.)|(1))");
		//            MatchCollection matches = regex.Matches(item1.ToLower());
		//            foreach (Match item2 in matches)
		//            {
		//                if (dictionary.ContainsKey(item2.Value))
		//                {
		//                    dictionary[item2.Value]++;
		//                }
		//                else
		//                {
		//                    dictionary.Add(item2.Value, 1);
		//                }


		//            }
		//        }

		//    }
		//    using (StreamWriter sw = new StreamWriter("Word.txt", false, System.Text.Encoding.Default))
		//    {
		//        foreach (var item in dictionary)
		//        {
		//            sw.WriteLine(item.Key + " " + item.Value);

		//        }

		//    }
		//    foreach (var item in dictionary)
		//    {
		//        Console.WriteLine(item.Key + " " + item.Value);
		//    }
		//    return 0;
		//}

		
		public int SaveToFile(IOrderedEnumerable<KeyValuePair<string, int>> words, string savefile)
        {
            //Text file = new Text();
            ////- Save - сохранение слов в файл
            //public void Save(string path)
            //{
            //    BinaryFormatter binFormat = new BinaryFormatter();
            //    using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            //    {
            //        binFormat.Serialize(fStream, file);

            //    }
            //}
            try
            {
                StreamWriter SW = new StreamWriter(savefile + "\\WordResult.txt");
				foreach (var item in words)
				{
					byte[] array = System.Text.Encoding.Default.GetBytes(item.Key + "" + item.Value); SW.WriteLine(item.ToString());
				}
				SW.Close();
                Console.WriteLine("[ Word count finish ]");

                return 0;
            }
			catch (Exception)
			{

				return 1;
			}

		}
		public IOrderedEnumerable<KeyValuePair<string, int>> SortDescending(Dictionary<string, int> SD)
		{
			return SD.OrderByDescending(i => i.Value);
		}
	}
}
