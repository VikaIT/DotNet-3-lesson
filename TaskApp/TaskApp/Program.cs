using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 0;
			Task task = new Task(() => {
				for (int i = 0; i < 100; i++)
				{
					a += i;
				}
				Console.WriteLine(a);
			});
			task.Start();
			Console.ReadLine();
		}
	}
}
