using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMVCConsole.Model
{
	class Tip//class za smetka
	{
		private double amount;//sum za smetka
		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		private double percent; //percent for waiter	
		public double Percent
		{
			get { return percent; }
			set
			{
				if (value > 1)
				{
					percent = value / 100.0; //drobno delene
				}
				else
				{
					percent = value;
				}

			}
		}

		public Tip(double amount, double percent)
		{
			this.Amount = amount;
			this.Percent = percent;
		}

		public Tip():this(0,0){}

		public double CalculateTip()
		{ 
			return Amount * Percent;
		}
		public double CalculateTotal()
		{
			return CalculateTip() + Amount;
		}


    }
}
