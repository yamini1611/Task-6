using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");
            double amount  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int  year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            var SimpleInterest = (double amount, int year , double rate) =>
            {
                double SI = amount * rate * year /100;
                return SI;
            };

            Console.WriteLine("Simple Interest : " + SimpleInterest(rate ,year ,amount));
            Console.ReadLine();
        }

    }
}

