using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMVCConsole.View
{
    class Display
    {
        
        public double Amount { get; set; }//ot Input
        public double Percent { get; set; }//ot Input
        public double Total { get; set; }//kum Output
        public double Tip { get; set; }//kum Output

        public void Imput()//GetValues()
        {
            Console.Write("Amount: ");
            this.Amount = double.Parse(Console.ReadLine());
            Console.Write("Percent: ");
            this.Percent = double.Parse(Console.ReadLine());
        }
        public void Output()//ShowTipAndTotal()
        {
            Console.WriteLine($"Your tip is: {this.Tip:C}");
            Console.WriteLine($"The total will be: {this.Total:C}" );
        }
    }
}
