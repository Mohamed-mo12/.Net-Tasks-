using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    class Teachers : Employees , Salary
    {

        private const int wage = 90;

        public int Loggedhour { get; set; }
        public string  Subject { get; set; }

        public Teachers(string name, int id, int age, string adress, string email, string subject,int loggedhour) : base(name, id, adress, age, email)
        {
            Subject = subject;
            Loggedhour = loggedhour; 
        }



        public override int Age
        {
            get => base.Age; set
            {
                if (value >= 25 && value <= 50)
                {
                    base.Age = value;

                }
                else
                {
                    Console.WriteLine(" invalid age ");
                }
            }
        }

         public int salary()
        {
            int salary = Loggedhour * wage;

            return salary; 
        }

        public override void display_info()
        {
            base.display_info();
            Console.WriteLine($"you salary for this month is : {salary()} \n your subject is {Subject} ");
        }
    }
}
