using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    class Manager : Employees, Salary
    {

        private const int Wage = 100;
        public int Loggedhour { get; set; }

        public Manager(string name, int id, int age, string address, string email, int loggerhour) : base(name, id, address, age, email)
        {
            Loggedhour = loggerhour;
        }


        public override int Age
        {
            get => base.Age; set
            {
                if (value > 60)
                {
                    Console.WriteLine(" ivalid age");
                }
                else
                {
                    base.Age = value;
                }
            }
        }

        public override void display_info()
        {
            base.display_info();

            Console.WriteLine($" you salary this month is {salary()} ");


        }

         public int salary()
        {
            int salary = Loggedhour * Wage;

            return salary;

        }
    }
}
