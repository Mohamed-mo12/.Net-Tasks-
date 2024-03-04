using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Contact
    {
        private List<string> users = new List<string>();

        public List<string> User { get { return users; } set { users = value; } }


        public List<string> add_user(string add) {

            User.Add(add);
            return User; 
        }

        public List<string> delete_user(string delete)
        {
            if (User.Contains(delete))
            {
                User.Remove(delete);
                Console.WriteLine(" you remove this user ");
            }
            else
            {
                Console.WriteLine($" {delete} not found ");
            }

            return User; 
        }


        public void Show_users() {

            Console.WriteLine(" this is All User in the list ");

            foreach (var item in User)
            {
                Console.WriteLine(item);
            }
        
        }


        public void number_users() {

            Console.WriteLine(User.Count());
        
        }

        public string search_user(string name) {

            foreach (var item in User)
            {
                if (item == name)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(" not exist ");
                }
            }

            return null; 
        
        }






    }
}
