using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int group = 4;

             int eachBill = 13;

             Console.WriteLine(group * eachBill
             

            int initMoney = 29;
            int finalMoney = 41;

            Console.WriteLine(finalMoney - initMoney);
            

            int eCost = 3;
            int money = 12;

            Console.WriteLine(money / eCost);
            

            int student = 331;
            int studentCar = 7;
            int Bus = 6;

            Console.WriteLine((student - studentCar) / Bus);
            */

            Console.WriteLine("Please enter your age");

            int userAge = int.Parse(Console.ReadLine());

            if(userAge>=0 && userAge<=2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if(userAge>=3 && userAge<=4) //or can be expressed as (userAge ==3 || userAge == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }

        }
    }
}
