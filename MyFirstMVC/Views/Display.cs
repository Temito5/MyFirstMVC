using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {
        public double Amount { set; get; }
        public double Percent { set; get; }
        public double TipSum { get; set; }
        public double TotalSum { get; set; }
        public void Input()
        {
            Console.Write("Въведи сумата на сметката:");
            double sum=double.Parse(Console.ReadLine());
            this.Amount = sum;

            Console.Write("Въведи процент на келнера:");
            double percent = double.Parse(Console.ReadLine());
            this.Percent = percent;
        }

        public void Output()
        {
            Console.WriteLine($"Бакшиш за сервитьора е : {this.TipSum}лв.");
            Console.WriteLine($"Сумата за плащане е : {this.TotalSum}лв.");
        }
    }
}
