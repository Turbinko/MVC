using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.View
{
    class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }

        public void Input()
        {
            Console.CursorVisible = true;
            Console.Title = "Restaurant";
            Console.Write("Enter the amount of the meal: ");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("Enter the percent you want to tip: ");
            Percent = double.Parse(Console.ReadLine());
            Console.CursorVisible = false;
        }
        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|*````````````TIP````````````*|");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|     " + DateTime.Now + "   |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine($"|   Your tip is: {TipAmount:C}     |");
            Console.WriteLine($"|   The total is: {Total:C}   |");
            Console.WriteLine("|-----------------------------|");
            Console.ForegroundColor = ConsoleColor.White;
            Beep();
        }
        public void Beep()
        {
            Console.Beep();
        }
    }
}
