using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person();
            Factors fctr = new Factors();
            Weight wg = new Weight();

            user.CallPerson();

            //
            Console.WriteLine("How many packs of ciggies do you smoke per week?");
            fctr.Smoke =Int32.Parse(Console.ReadLine());
           
            fctr.Wsmoke = 20;
            fctr.Walcohool = 10;
            fctr.Wdeciese = 10;
            fctr.Wexercise = 10;

/*
            Console.WriteLine("Enter player Speed");
            var spd = Console.ReadLine();
            plyr1.skls.Speed = Convert.ToInt32(spd);
*/

            if (fctr.Smoke < 3)
            {
                fctr.Wsmoke = fctr.Wsmoke - 5;
               
                Console.WriteLine(fctr.Wsmoke);

                Console.ReadLine();
            }
            else if (fctr.Smoke > 3 && fctr.Smoke <= 6)
            {
                fctr.Wsmoke = fctr.Wsmoke - 10;
                Console.WriteLine(fctr.Wsmoke);
                Console.ReadLine();

            }
                else if(fctr.Smoke > 7)
            {
                fctr.Wsmoke = fctr.Wsmoke - 20;
                Console.Write(fctr.Wsmoke);
                Console.ReadLine();
            }
   
            //

            if (fctr.Exercise < 1)
            {
                Console.WriteLine();
            }
            else if (fctr.Exercise >= 1 && fctr.Exercise <= 3)
            {
                Console.WriteLine();
            }
            else if (fctr.Exercise > 3)
            {
                Console.WriteLine();
            }

            if (fctr.Alcohool < 1)
            {
                Console.WriteLine();
            }
            else if (fctr.Alcohool >= 1 && fctr.Smoke <= 3)
            {
                Console.WriteLine();
            }
            else if (fctr.Alcohool > 3)
            {
                Console.WriteLine();
            }

        }

        


    }


}

