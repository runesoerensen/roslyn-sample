using System;
using System.Threading;

namespace RoslynSample.Worker
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine($"Hello there. The clock is now {DateTime.UtcNow}");
			Thread.Sleep(5000);

			Console.WriteLine("Bye");
			Thread.Sleep(1000);
		}
	}
}
