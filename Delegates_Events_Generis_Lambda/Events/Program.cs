using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	// Events are encapsulated delegates
	class Program
	{
		public delegate void BeforeCalculate();
		public static event BeforeCalculate BeforeCalculateEvent;

		public static void calculate()
		{
			Console.WriteLine(4 * 4);
		}
		static void Main(string[] args)
		{
			//Number num = new Number(1234567);

			BeforeCalculateEvent += calculate;
			BeforeCalculateEvent();
		}
	}
	/// <summary>
	/// This is a publisher class that publishes the beforePrint event.
	/// The event in this class is fired by the subscriber class Number 
	/// when a new instance of Number is created, thus calling all Print methods
	/// </summary>
	public class PrintHelper
	{
		// Declare a delegate
		public delegate void BeforePrint();
		// Declare event of type delegate
		public event BeforePrint BeforePrintEvent;

		public PrintHelper()
		{

		}
		public void FireEvent()
		{
			BeforePrintEvent();
		}
		public void PrintNumber(int num)
		{	
			// check if no class is subscribed to event
			// call delegate method before going to print
			//if (beforePrintEvent != null)
			//	beforePrintEvent();

			Console.WriteLine("Number: {0, -12:N0}", num);
		}
		public void PrintDecimal(int dec)
		{
			// A simplified version of "if" statement in PrintNumber
			// which does the same thing
			//beforePrintEvent?.Invoke();

			Console.WriteLine("Decimal: {0:G}", dec);
		}
		public void PrintMoney(int money)
		{
			//beforePrintEvent?.Invoke();

			Console.WriteLine("Money: {0:C}", money);
		}
		public void PrintTemperature(int num)
		{
			//beforePrintEvent?.Invoke();

			Console.WriteLine("Temperature: {0,4:N1} F", num);
		}
		public void PrintHexadecimal(int dec)
		{
			//beforePrintEvent?.Invoke();

			Console.WriteLine("Hexadecimal: {0:X}", dec);
		}
	}
	/// <summary>
	/// Event Subscriber
	/// All subscribers should provide a Handler function
	/// which is called when a publisher raises an event
	/// </summary>
	class Number
	{
		private int _value;
		public int Value { get => _value; set => _value = value; }
		private PrintHelper _printHelper;
		public Number(int val)
		{
			_value = val;
			_printHelper = new PrintHelper();
			// Subscribe to beforePrintEvent event
			_printHelper.BeforePrintEvent += printHelper_beforePrintEvent;
			_printHelper.FireEvent();
		}
		//beforePrintevent handler
		void printHelper_beforePrintEvent()
		{
			Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
			
			_printHelper.PrintDecimal(1234567);
			_printHelper.PrintHexadecimal(1234567);
			_printHelper.PrintMoney(1234567);
			_printHelper.PrintNumber(1234567);
			_printHelper.PrintTemperature(1234567);
		}
		//public void PrintMoney()
		//{
		//	_printHelper.PrintMoney(_value);
		//}
		//public void PrintNumber()
		//{
		//	_printHelper.PrintNumber(_value);
		//}
	}
}
