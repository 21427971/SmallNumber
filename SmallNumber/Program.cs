using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace SmallNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //to check the smaller number between two numbers
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            int SmallNumber = 0;
            if(num1<num2)
            {
                SmallNumber = num1;
                Console.WriteLine("The small number is :{0}", SmallNumber);
            }
            else
                if(num2<num1)
            {
                SmallNumber = num2;
                Console.WriteLine("The small number is :{0}", SmallNumber);
            }
            else
                Console.WriteLine("Invalid");

        }
    }
}
