using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TasksApp
{
	class Program
	{
		static Stopwatch sw = new Stopwatch();
		private static void SpecialActionMethod()
		{
			Console.WriteLine("This action method takes no paremeters, returns nothing but just performs an action.");
			Console.WriteLine($"This method finished in {sw.ElapsedMilliseconds}");
		}
		static void Main(string[] args)
		{
			// Start stopwatch
			sw.Start();

			var task1 = Task.Run( () =>
				{
					Console.WriteLine("Task1 is running.");
					Console.WriteLine($"Task 1 finished in {sw.ElapsedMilliseconds}");
				});

			var actionDelegate = new Action(SpecialActionMethod); // pass in as argument
			var task2 = new Task(actionDelegate);
			task2.Start();

			// Array of tasks
			Task[] tasks = new Task[]
			{
				new Task( () => { }),
				new Task( () => { }),
				new Task( () => { }),
			};

			foreach (var t in tasks)
			{
				t.Start();
			}

			// Parallel forach loop
			int[] mycollection = new int[] { 10, 20 ,30, 40, 50};
			Parallel.ForEach(mycollection, (item) => { 
				//Thread.Sleep(item * 100); Console.WriteLine($"Item finish in {sw.ElapsedMilliseconds}"); 
			});

			var start = sw.ElapsedMilliseconds;
			foreach (var item in mycollection)
			{
				//Thread.Sleep(item * 100);
			}
			var finish = sw.ElapsedMilliseconds;
			var total = finish - start;
			Console.WriteLine($"Sync foreach started at {start} ms, finisht at {finish} ms, completed in {total} ms.");

			// LINQ query
			// could use this on real database query if many queries and each one possibly take a long time
			var dbOutput = (from item in mycollection select item * item).AsParallel().ToList();
			//Console.WriteLine($"Main() has finished in {sw.ElapsedMilliseconds} ms.");

			// Get data from tasks
			var taskNoReturnData = new Task(() => { });
			var taskWithReturnData = new Task<int>(() => {
				int total = 0;
				for (int i = 0; i < 100; i++)
				{
					total += i;
				}
				return total; 
			});
			taskWithReturnData.Start();	// start task and get result
			Console.WriteLine($"\n\ntaskWithReturnData: {taskWithReturnData.Result}");

			Console.ReadLine();
		}
	}
}
