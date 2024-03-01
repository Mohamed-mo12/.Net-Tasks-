using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    abstract class Employees
    {

        public Employees()
        {

        }


        public Employees(string name, int id, string address, int age, string email)
        {
            Name = name;
            Id = id;
            Address = address;
            Age = age;
            Email = email;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public string Address { get; set; }
        public virtual int Age { get; set; }
        public string Email { get; set; }



        public virtual void display_info()
        {

            Console.WriteLine($"you name is {Name} \n  Id : {Id} \n Age : {Age} \n Email  : {Email} ");


        }
    }
}
