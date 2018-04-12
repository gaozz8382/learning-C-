using System;
namespace PolymorphismApplication
{
	class Printdata
	{
		void print(int i)
		{
			Console.WriteLine("Printing int: {0}", i);
		}
		
		void print(double f)
		{
			Console.WriteLine("Printing float: {0}", f);
		}
		
		void print(string s)
		{
			Console.WriteLine("Printing string: {0}", s);
		}
		
		static void Main(string[] args)
		{
			Printdata p = new Printdata();
			// 调用 print 来打印整数
			p.print(5);
			// 调用 print 来打印浮点数
			p.print(500.263);
			// 调用 print 来打印字符串
			p.print("Hello C#");
			Console.ReadKey();
		}
	}	
}