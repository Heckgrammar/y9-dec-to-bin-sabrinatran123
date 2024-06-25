using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12";
            Console.WriteLine(myString); //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
            Console.WriteLine(myStringAsInt);

            Console.WriteLine("Enter denary number: ");
            numberConversion(Convert.ToInt32(Console.ReadLine()), 2);
           
            //CODE GOES HERE
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            string backwardsbin = null;
            while (number > 0)
            {
                backwardsbin = backwardsbin + Convert.ToString(number % 2);
                number = number / 2;
                Console.WriteLine(backwardsbin);
            }
            string[] bin = {null,null};

            for (int i = 0; i < (backwardsbin.Length-1); i++)
            {
                bin[i] = (backwardsbin.Substring(backwardsbin.Length - i));
                Console.WriteLine(" ");
                Console.Write(bin[i]);
            }
            return Convert.ToString(number + numberbase);

        }
    }
}
