using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_EventArgs
{
	class Program
	{
		static void Main(string[] args)
		{
			Counter c = new Counter(new Random().Next(10));
			c.ThresholdReached += c_ThresholdReached;

			Console.WriteLine("press 'a' key to increase total");
			while (Console.ReadKey(true).KeyChar == 'a')
			{
				Console.WriteLine("adding one");
				c.Add(1);
				Console.WriteLine("run my eventhandler");
				c.print(69, "isaac");
			}
		}
		static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
		{
			Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
			Environment.Exit(0);
		}
		static void c_MineArgs(object sender, MyEventArgs e)
		{
			Console.WriteLine("The name is {0}, the age is {1}.", e.Name, e.Age);
		}
	}

	class Counter
	{
		private int _threshold;
		private int _total;

		public Counter(int passedThreshold)
		{
			_threshold = passedThreshold;
		}

		public void Add(int x)
		{
			_total += x;
			if (_total >= _threshold)
			{
				ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
				args.Threshold = _threshold;
				args.TimeReached = DateTime.Now;
				OnThresholdReached(args);
			}
		}
		public void print(int age, string name)
		{
			MyEventArgs args = new MyEventArgs();
			args.Age = age;
			args.Name = name;
			OnMyEventArgs(args);
		}
		protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
		{
			EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
			if (handler != null)
			{
				handler(this, e);
			}
		}
		protected virtual void OnMyEventArgs(MyEventArgs e)
		{
			// same as for OnThresholdReached
			MyEvArgs?.Invoke(this, e);
		}
		// This method will handle the event when event provides data
		public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

		// Eventhandler for MyEventArgs
		public event EventHandler<MyEventArgs> MyEvArgs;
	}

	public class ThresholdReachedEventArgs : EventArgs
	{
		public int Threshold { get; set; }
		public DateTime TimeReached { get; set; }
	}
	public class MyEventArgs : EventArgs
	{
		public int Age { get; set; }
		public string Name { get; set; }
	}
}
