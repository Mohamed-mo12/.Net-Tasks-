using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("mohamed", 12088, 45, "Dokki", "mohamed@gmail.com", 200);
            m1.display_info();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Students s1 = new Students("Ahmed",12055,"Faisal",16,"Ahmed@gmail","Basketball",Students.Grade.B);
            s1.display_info();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Teachers T1 = new Teachers("mahmoud",14055,50,"Giza","mahmoud@gmail.com","Arabic",180);
            T1.display_info();
            





            Console.ReadKey();
        }
    }
}
