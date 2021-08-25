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

			string path = @"D:\WordsTEst";
			Frequent_Dictionary t = new Frequent_Dictionary(path);
			if (t == null)
			{
				Assert.Inconclusive();
			}
		}
		[TestMethod]
		public void TestMethod2()
		{
			string path = Directory.GetCurrentDirectory();
			Frequent_Dictionary t = new Frequent_Dictionary(path);
			Assert.IsFalse(t.GetFiles.Contains(".txt"));
		}
		[TestMethod]
		public void TestMethod3()
		{
		}
		[TestMethod]
		public void TestMethod4()
		{
		}
		[TestMethod]
		public void TestMethod5()
		{
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
