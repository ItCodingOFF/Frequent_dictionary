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
			Assert.IsFalse(fd.GetFiles.Contains(".txt"));
		}
		[TestMethod]
		public void TestMethod3()
		{
			string dirpath = Directory.GetCurrentDirectory();
			Frequent_Dictionary t = new Frequent_Dictionary(dirpath);
			Dictionary<string, int> v = t.ReadText();
			IOrderedEnumerable<KeyValuePair<string, int>> vacabulary = t.SortDescending(v);
			string fileresult = Directory.GetCurrentDirectory();
			Assert.IsTrue(t.SaveToFile(vacabulary, fileresult) == 0);

		}
		[TestMethod]
		public void TestMethod4()
		{
			// Создаем рандомный массив
			Random random = new Random();
			double[] result = new double[100];
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = random.NextDouble();
			}
			//// Создаем экземпляр класса
			//Frequent_Dictionary arr = new Frequent_Dictionary();
			//// Добавляем все значения в хэш таблицу
			//HashSet<double> hashSet = new HashSet<double>();
			//for (int i = 0; i < result.Length; i++)
			//{
			//	hashSet.Add(result[i]);
			//}
			//// Сортируем результатирующий массив методом своего класса
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
			string path = Directory.GetCurrentDirectory();
			Frequent_Dictionary t = new Frequent_Dictionary(path);
			Dictionary<string, int> v = t.ReadText();
			IOrderedEnumerable<KeyValuePair<string, int>> vacabulary = t.SortDescending(v);

			//Assert.IsTrue(vacabulary.First().Value > vacabulary.Last().Value);
			//using (FileStream fs = File.OpenRead("test.txt"))
			//{
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
		}
		[TestMethod]
		public void TestMethod7()
		{
		}
		[TestMethod]
		public void TestMethod8()
		{
		}
		[TestMethod]
		public void TestMethod9()
		{
		}
		[TestMethod]
		public void TestMethod10()
		{
		}
	}
}
