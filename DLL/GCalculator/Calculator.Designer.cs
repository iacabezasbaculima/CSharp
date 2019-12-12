namespace GCalculator
{
	partial class Calculator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btAdd = new System.Windows.Forms.Button();
			this.btSub = new System.Windows.Forms.Button();
			this.btMult = new System.Windows.Forms.Button();
			this.btDiv = new System.Windows.Forms.Button();
			this.lbFirstNum = new System.Windows.Forms.Label();
			this.lbSecondNum = new System.Windows.Forms.Label();
			this.txFirstNum = new System.Windows.Forms.TextBox();
			this.txSecondNum = new System.Windows.Forms.TextBox();
			this.txResult = new System.Windows.Forms.TextBox();
			this.btnOne = new System.Windows.Forms.Button();
			this.btnTwo = new System.Windows.Forms.Button();
			this.btnThree = new System.Windows.Forms.Button();
			this.btnFour = new System.Windows.Forms.Button();
			this.btnFive = new System.Windows.Forms.Button();
			this.btnSix = new System.Windows.Forms.Button();
			this.btnSeven = new System.Windows.Forms.Button();
			this.btnEight = new System.Windows.Forms.Button();
			this.btnNine = new System.Windows.Forms.Button();
			this.btnPlusMinus = new System.Windows.Forms.Button();
			this.btnZero = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnEqual = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btAdd
			// 
			this.btAdd.BackColor = System.Drawing.Color.Red;
			this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAdd.Location = new System.Drawing.Point(701, 137);
			this.btAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(114, 53);
			this.btAdd.TabIndex = 0;
			this.btAdd.Text = "+";
			this.btAdd.UseVisualStyleBackColor = false;
			this.btAdd.Click += new System.EventHandler(this.OnButtonCalculate);
			// 
			// btSub
			// 
			this.btSub.BackColor = System.Drawing.Color.ForestGreen;
			this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSub.Location = new System.Drawing.Point(701, 222);
			this.btSub.Margin = new System.Windows.Forms.Padding(4);
			this.btSub.Name = "btSub";
			this.btSub.Size = new System.Drawing.Size(114, 53);
			this.btSub.TabIndex = 1;
			this.btSub.Text = "-";
			this.btSub.UseVisualStyleBackColor = false;
			this.btSub.Click += new System.EventHandler(this.OnButtonCalculate);
			// 
			// btMult
			// 
			this.btMult.BackColor = System.Drawing.Color.DodgerBlue;
			this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMult.Location = new System.Drawing.Point(701, 301);
			this.btMult.Margin = new System.Windows.Forms.Padding(4);
			this.btMult.Name = "btMult";
			this.btMult.Size = new System.Drawing.Size(114, 53);
			this.btMult.TabIndex = 2;
			this.btMult.Text = "x";
			this.btMult.UseVisualStyleBackColor = false;
			this.btMult.Click += new System.EventHandler(this.OnButtonCalculate);
			// 
			// btDiv
			// 
			this.btDiv.BackColor = System.Drawing.Color.DeepPink;
			this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDiv.Location = new System.Drawing.Point(701, 389);
			this.btDiv.Margin = new System.Windows.Forms.Padding(4);
			this.btDiv.Name = "btDiv";
			this.btDiv.Size = new System.Drawing.Size(114, 53);
			this.btDiv.TabIndex = 3;
			this.btDiv.Text = "÷";
			this.btDiv.UseVisualStyleBackColor = false;
			this.btDiv.Click += new System.EventHandler(this.OnButtonCalculate);
			// 
			// lbFirstNum
			// 
			this.lbFirstNum.AutoSize = true;
			this.lbFirstNum.Location = new System.Drawing.Point(188, 345);
			this.lbFirstNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbFirstNum.Name = "lbFirstNum";
			this.lbFirstNum.Size = new System.Drawing.Size(93, 17);
			this.lbFirstNum.TabIndex = 4;
			this.lbFirstNum.Text = "First Number:";
			this.lbFirstNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbSecondNum
			// 
			this.lbSecondNum.AutoSize = true;
			this.lbSecondNum.Location = new System.Drawing.Point(167, 389);
			this.lbSecondNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSecondNum.Name = "lbSecondNum";
			this.lbSecondNum.Size = new System.Drawing.Size(114, 17);
			this.lbSecondNum.TabIndex = 5;
			this.lbSecondNum.Text = "Second Number:";
			this.lbSecondNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txFirstNum
			// 
			this.txFirstNum.Location = new System.Drawing.Point(320, 342);
			this.txFirstNum.Margin = new System.Windows.Forms.Padding(4);
			this.txFirstNum.Name = "txFirstNum";
			this.txFirstNum.Size = new System.Drawing.Size(132, 23);
			this.txFirstNum.TabIndex = 6;
			// 
			// txSecondNum
			// 
			this.txSecondNum.Location = new System.Drawing.Point(320, 386);
			this.txSecondNum.Margin = new System.Windows.Forms.Padding(4);
			this.txSecondNum.Name = "txSecondNum";
			this.txSecondNum.Size = new System.Drawing.Size(132, 23);
			this.txSecondNum.TabIndex = 7;
			// 
			// txResult
			// 
			this.txResult.Location = new System.Drawing.Point(320, 431);
			this.txResult.Margin = new System.Windows.Forms.Padding(4);
			this.txResult.Name = "txResult";
			this.txResult.Size = new System.Drawing.Size(132, 23);
			this.txResult.TabIndex = 8;
			// 
			// btnOne
			// 
			this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOne.Location = new System.Drawing.Point(137, 222);
			this.btnOne.Margin = new System.Windows.Forms.Padding(4);
			this.btnOne.Name = "btnOne";
			this.btnOne.Size = new System.Drawing.Size(100, 28);
			this.btnOne.TabIndex = 10;
			this.btnOne.Text = "1";
			this.btnOne.UseVisualStyleBackColor = true;
			this.btnOne.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnTwo
			// 
			this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTwo.Location = new System.Drawing.Point(245, 222);
			this.btnTwo.Margin = new System.Windows.Forms.Padding(4);
			this.btnTwo.Name = "btnTwo";
			this.btnTwo.Size = new System.Drawing.Size(100, 28);
			this.btnTwo.TabIndex = 11;
			this.btnTwo.Text = "2";
			this.btnTwo.UseVisualStyleBackColor = true;
			this.btnTwo.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnThree
			// 
			this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThree.Location = new System.Drawing.Point(353, 222);
			this.btnThree.Margin = new System.Windows.Forms.Padding(4);
			this.btnThree.Name = "btnThree";
			this.btnThree.Size = new System.Drawing.Size(100, 28);
			this.btnThree.TabIndex = 12;
			this.btnThree.Text = "3";
			this.btnThree.UseVisualStyleBackColor = true;
			this.btnThree.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnFour
			// 
			this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFour.Location = new System.Drawing.Point(137, 172);
			this.btnFour.Margin = new System.Windows.Forms.Padding(4);
			this.btnFour.Name = "btnFour";
			this.btnFour.Size = new System.Drawing.Size(100, 28);
			this.btnFour.TabIndex = 13;
			this.btnFour.Text = "4";
			this.btnFour.UseVisualStyleBackColor = true;
			this.btnFour.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnFive
			// 
			this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFive.Location = new System.Drawing.Point(245, 172);
			this.btnFive.Margin = new System.Windows.Forms.Padding(4);
			this.btnFive.Name = "btnFive";
			this.btnFive.Size = new System.Drawing.Size(100, 28);
			this.btnFive.TabIndex = 14;
			this.btnFive.Text = "5";
			this.btnFive.UseVisualStyleBackColor = true;
			this.btnFive.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnSix
			// 
			this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSix.Location = new System.Drawing.Point(353, 172);
			this.btnSix.Margin = new System.Windows.Forms.Padding(4);
			this.btnSix.Name = "btnSix";
			this.btnSix.Size = new System.Drawing.Size(100, 28);
			this.btnSix.TabIndex = 15;
			this.btnSix.Text = "6";
			this.btnSix.UseVisualStyleBackColor = true;
			this.btnSix.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnSeven
			// 
			this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeven.Location = new System.Drawing.Point(137, 122);
			this.btnSeven.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeven.Name = "btnSeven";
			this.btnSeven.Size = new System.Drawing.Size(100, 28);
			this.btnSeven.TabIndex = 16;
			this.btnSeven.Text = "7";
			this.btnSeven.UseVisualStyleBackColor = true;
			this.btnSeven.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnEight
			// 
			this.btnEight.Location = new System.Drawing.Point(245, 122);
			this.btnEight.Margin = new System.Windows.Forms.Padding(4);
			this.btnEight.Name = "btnEight";
			this.btnEight.Size = new System.Drawing.Size(100, 28);
			this.btnEight.TabIndex = 17;
			this.btnEight.Text = "8";
			this.btnEight.UseVisualStyleBackColor = true;
			this.btnEight.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnNine
			// 
			this.btnNine.Location = new System.Drawing.Point(353, 122);
			this.btnNine.Margin = new System.Windows.Forms.Padding(4);
			this.btnNine.Name = "btnNine";
			this.btnNine.Size = new System.Drawing.Size(100, 28);
			this.btnNine.TabIndex = 18;
			this.btnNine.Text = "9";
			this.btnNine.UseVisualStyleBackColor = true;
			this.btnNine.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnPlusMinus
			// 
			this.btnPlusMinus.Location = new System.Drawing.Point(137, 269);
			this.btnPlusMinus.Name = "btnPlusMinus";
			this.btnPlusMinus.Size = new System.Drawing.Size(100, 28);
			this.btnPlusMinus.TabIndex = 19;
			this.btnPlusMinus.Text = "+/-";
			this.btnPlusMinus.UseVisualStyleBackColor = true;
			this.btnPlusMinus.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnZero
			// 
			this.btnZero.Location = new System.Drawing.Point(245, 269);
			this.btnZero.Name = "btnZero";
			this.btnZero.Size = new System.Drawing.Size(100, 28);
			this.btnZero.TabIndex = 20;
			this.btnZero.Text = "0";
			this.btnZero.UseVisualStyleBackColor = true;
			this.btnZero.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(354, 269);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(99, 28);
			this.btnClear.TabIndex = 21;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// btnEqual
			// 
			this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEqual.Location = new System.Drawing.Point(187, 423);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(94, 41);
			this.btnEqual.TabIndex = 23;
			this.btnEqual.Text = "=";
			this.btnEqual.UseVisualStyleBackColor = true;
			this.btnEqual.Click += new System.EventHandler(this.GetUserButtonValue);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnZero);
			this.Controls.Add(this.btnPlusMinus);
			this.Controls.Add(this.btnNine);
			this.Controls.Add(this.btnEight);
			this.Controls.Add(this.btnSeven);
			this.Controls.Add(this.btnSix);
			this.Controls.Add(this.btnFive);
			this.Controls.Add(this.btnFour);
			this.Controls.Add(this.btnThree);
			this.Controls.Add(this.btnTwo);
			this.Controls.Add(this.btnOne);
			this.Controls.Add(this.txResult);
			this.Controls.Add(this.txSecondNum);
			this.Controls.Add(this.txFirstNum);
			this.Controls.Add(this.lbSecondNum);
			this.Controls.Add(this.lbFirstNum);
			this.Controls.Add(this.btDiv);
			this.Controls.Add(this.btMult);
			this.Controls.Add(this.btSub);
			this.Controls.Add(this.btAdd);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Calculator";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Calculator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btSub;
		private System.Windows.Forms.Button btMult;
		private System.Windows.Forms.Button btDiv;
		private System.Windows.Forms.Label lbFirstNum;
		private System.Windows.Forms.Label lbSecondNum;
		private System.Windows.Forms.TextBox txFirstNum;
		private System.Windows.Forms.TextBox txSecondNum;
		private System.Windows.Forms.TextBox txResult;
		private System.Windows.Forms.Button btnOne;
		private System.Windows.Forms.Button btnTwo;
		private System.Windows.Forms.Button btnThree;
		private System.Windows.Forms.Button btnFour;
		private System.Windows.Forms.Button btnFive;
		private System.Windows.Forms.Button btnSix;
		private System.Windows.Forms.Button btnSeven;
		private System.Windows.Forms.Button btnEight;
		private System.Windows.Forms.Button btnNine;
		private System.Windows.Forms.Button btnPlusMinus;
		private System.Windows.Forms.Button btnZero;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnEqual;
	}
}