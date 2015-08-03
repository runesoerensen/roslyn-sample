using System;
using System.Threading;

namespace RoslynSample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello world");
			Thread.Sleep(5000);

			Console.WriteLine("Bye");
			Thread.Sleep(1000);
		}
	}
}
