using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp_17_Frequent_Dictionary;
//using UnitTestProject;
//using static UnitTestProject.Frequent_Dictionary;



namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string dirpath = @"D:\WordsTEst";
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			if (fd == null)
			{
				Assert.Inconclusive();
			}
		}
		[TestMethod]
		public void TestMethod2()
		{
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Assert.IsFalse(fd.GetFiles.Contains("WordResult.txt"));
		}
		[TestMethod]
		public void TestMethod3()
		{
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Dictionary<string, int> v = fd.ReadText();
			IOrderedEnumerable<KeyValuePair<string, int>> words = fd.SortDescending(v);
			string savefile = Directory.GetCurrentDirectory();
			Assert.IsTrue(fd.SaveToFile(words, savefile) == 0);

		}
		[TestMethod]
		public void TestMethod4()
		{
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Dictionary<string, int> v = fd.ReadText();
			IOrderedEnumerable<KeyValuePair<string, int>> words = fd.SortDescending(v);
			string savefile = Directory.GetCurrentDirectory();
			Assert.IsTrue(fd.SaveToFile(words, savefile) == 0);

			//Random random = new Random();
			//double[] result = new double[100];
			//for (int i = 0; i < result.Length; i++)
			//{
			//	result[i] = random.NextDouble();
			//}

			//Frequent_Dictionary arr = new Frequent_Dictionary()ж
			//HashSet<double> hashSet = new HashSet<double>();
			//for (int i = 0; i < result.Length; i++)
			//{
			//	hashSet.Add(result[i]);
			//}

			//arr.SaveToFile(result);
			//for (int i = 0; i < result.Length; i++)
			//{
			//	if (!hashSet.Contains(result[i]))
			//	{
			//		Assert.Fail("The TestSortThisNumbers is FAILED!");
			//	}
			//}
		}
		[TestMethod]
		public void TestMethod5()
		{
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Dictionary<string, int> v = fd.ReadText();
			IOrderedEnumerable<KeyValuePair<string, int>> vacabulary = fd.SortDescending(v);
			

			//using (FileStream fs = File.OpenRead("test.txt"))
			//{
			//  Assert.IsTrue(vacabulary.First().Value > vacabulary.Last().Value);
			//	byte[] temp = new byte[fs.Length];
			//	fs.Read(temp, 0, temp.Length);
			//	string[] text = (System.Text.Encoding.Default.GetString(temp)).Split();
			//	test = new double[text.Length - 1];
			//	for (int i = 0; i < text.Length - 1; i++)
			//	{
			//		test[i] = Convert.ToDouble(text[i]);
			//	}
			//}
			//if (test.Length == source.Length)
			//{
			//	System.Array.Sort(test);
			//	for (int i = 0; i < test.Length; i++)
			//	{
			//		if (test[i] != source[i])
			//		{
			//			Assert.Fail("The TestSave is FAILED!");
			//		}
			//	}
			//}
			//else
			//{
			//	Assert.Fail("The TestSave is FAILED!");
			//}
		}
		[TestMethod]
		public void TestMethod6()
		{
			string dirpath = Directory.GetCurrentDirectory();

			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Dictionary<string, int> v = fd.ReadText();

			IOrderedEnumerable<KeyValuePair<string, int>> vacabulary = fd.SortDescending(v);
			Assert.IsFalse(v.First().Value > v.Last().Value);
		}
		[TestMethod]
		public void TestMethod7()
		{
			
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary t = new Frequent_Dictionary(dirpath);
			//Dictionary<string, int> v = t.ReadText();
			Assert.IsFalse(t.GetFiles == null);
		}
		[TestMethod]
		public void TestMethod8()
		{

			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Assert.IsNotNull(fd.ReadText());
			Dictionary<string, int> v = fd.ReadText();
			Assert.IsTrue(fd.SortDescending(v) != null);
		}
		[TestMethod]
		public void TestMethod9()
		{
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary fd = new Frequent_Dictionary(dirpath);
			Assert.IsNotNull(fd);
		}
		[TestMethod]
		public void TestMethod10()
		{
		}
	}
}
