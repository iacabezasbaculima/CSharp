using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibraryCore;

namespace GCalculator
{
	public partial class Calculator : Form
	{
		public Dictionary<string, int> pairs = new Dictionary<string, int>();
		
		public Calculator()
		{
			InitializeComponent();
		}

		private void Calculator_Load(object sender, EventArgs e)
		{

		}
		bool operatorSelected = false;
		
		public void GetUserButtonValue(object o, EventArgs e)
		{
			Button btn = (Button)o;
			
			// Take user input
			if(!operatorSelected)
			{
				txFirstNum.Text += btn.Text;
			}
			else if (operatorSelected)
			{
				txSecondNum.Text += btn.Text;
			}
			if(btn.Text == "+" || btn.Text == "-" || btn.Text == "x" || btn.Text == "÷")
			{
				operatorSelected = true;
			}

			// Clear user input and answer 
			if(btn.Name == "btnClear")
			{
				txFirstNum.Text = "";
				txSecondNum.Text = "";
				txResult.Text = "";
			}
		}	
		public void OnButtonCalculate(object o, EventArgs e)
		{
			Button btn = (Button)o;
			if (txFirstNum.Text != "" && txSecondNum.Text != "")
			{
				var num1 = Convert.ToInt32(txFirstNum.Text);
				var num2 = Convert.ToInt32(txSecondNum.Text);
				if (btn.Text == "+")
				{
					txResult.Text = CalculatorCore.Add(num1, num2).ToString();
				}
				else if (btn.Text == "-")
				{
					txResult.Text = CalculatorCore.Subtract(num1, num2).ToString();
				}
				else if (btn.Text == "x")
				{
					txResult.Text = CalculatorCore.Multiply(num1, num2).ToString();
				}
				else if (btn.Text == "÷")
				{
					txResult.Text = CalculatorCore.Divide(num1, num2).ToString();
				}
			}
		}
	}
}
