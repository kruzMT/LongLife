using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongLife
{
  public  class Person
    {
            string name;
            string surname;
            int age;

        /*   public Person(string name, string surname, int age)
           {
               this.name = name;
               this.surname = surname;
               this.age = age;
           }
          */
        public void CallPerson()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your Date of Birth");
            int age = Convert.ToInt32(Console.ReadLine());

                   
        }

    



    }
}
