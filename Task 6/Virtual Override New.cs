using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questiona
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
      public virtual void Display()
        {
            Console.WriteLine($"employee of Id {id} , Name :{name} ,salary :{salary}");
        }


    }
    public class HR : Employee
    {
        public double bonus { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Bonus  received {bonus} , salary received {salary}");
        }

    }
    
    internal class New { 
          static void Main(string[] args)
        {
            var a = new HR()
            {
             bonus = 10000,
             salary =20000,
             id=11,
             name ="YAMINI"
            };

            
            Employee employee = a ;
           a.Display();
            employee.Display();

            Console.ReadLine();

        }
    }
}

namespace Questionb
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public string Display() => $"employee of Id {id} , Name :{name} ,salary :{salary}";


    }
    public class HR : Employee
    {

        public double bonus { get; set; }

        public new double Display()
        {
       

            if (salary > 20000)
            {
                bonus = 2 * salary;
                
            }
            else if (salary > 50000)
            {
                bonus = 4 * salary;
            }
            
            Console.WriteLine($" Employee {name} getting salary of  {salary} with bonus {bonus}");
            return bonus;
        }

        internal class New
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter salary :");
                double salary = Convert.ToDouble(Console.ReadLine());
                var a = new HR()
                {
                    salary = salary,
                    id = 11,
                    name = "YAMINI",

                };


                Console.WriteLine(a.Display());

                Employee employee = a;
                Console.WriteLine(employee.Display());

                Console.ReadLine();

            }
        }
    }
}

