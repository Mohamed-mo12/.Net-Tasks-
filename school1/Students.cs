using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    class Students : Employees
    {

        public enum Grade { 
        A,
        B, 
        C
        }


        public Grade studentgrade { get; set; }
        public string Activity { get; set; }


        public Students(string name, int id, string address, int age, string email, string activity,Grade grade) : base(name, id, address, age, email)
        {
            studentgrade = grade; 
            Activity = activity;
        }


        public override int Age
        {
            get => base.Age; set
            {
                if (value > 19)
                {
                    Console.WriteLine(" invalid age");
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
            Console.WriteLine($" and your activity is : {Activity} \n  you in grade {studentgrade} ");
        }
    }
}
