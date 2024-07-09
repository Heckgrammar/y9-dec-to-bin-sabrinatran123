using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
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
            Console.WriteLine("Dec to bin (type db), bin to dec (type bd), hex to den (type hd) ");
            string conversiontype = Console.ReadLine();
            if (conversiontype == "db")
            {
                Console.WriteLine("Enter denary number: ");
                Console.WriteLine(DenToBin(Convert.ToInt32(Console.ReadLine()), 2));
            }
            else if (conversiontype == "bd")
            {
                Console.WriteLine("Enter binary number: ");
                Console.WriteLine(BinToDen(Console.ReadLine()));
            }
            else if (conversiontype == "hd")
            {
                Console.WriteLine("Enter hexadecimal number: ");
                Console.WriteLine(HexToDen(Console.ReadLine()));
            }
            Console.ReadLine();
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string DenToBin(int number, int numberbase)
        {
            //CODE GOES HERE
            string backwardsbin = null;
            string binary = null;
            Console.WriteLine("Valid? " + ValidationSub("no", number));
            while (number > 0)
            {
                backwardsbin = backwardsbin + Convert.ToString(number % numberbase);
                number = number / numberbase;
            }
            string[] bin = new string[20];

            for (int i = 0; i < (backwardsbin.Length); i++)
            {
                bin[i] = (backwardsbin.Substring(backwardsbin.Length - (1 + i), 1));
                binary = binary + bin[i];
            }
            Console.ReadLine();
            string result = binary;
            return result;
        }
        static string ValidationSub(string valid, int number)
        {
            while (valid == "no")
            {
                if (number >= 0)
                {
                    valid = "yes";
                }
                else
                {
                    valid = "no";
                }
            }
            return valid;
        }

        static string BinToDen(string number)
        {
            int den = 0;
            int[] binnumberline = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096 };

            string[] backwardsbin = new string[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                backwardsbin[i] = number.Substring(number.Length - (1 + i), 1);
                if (backwardsbin[i] == "1")
                {
                    den = den + binnumberline[i];
                }
            }
            return Convert.ToString(den);
        }

        static string HexToDen(string number)
        {
            int hex = 0;
            string[] hexArray
            string[] HexNumberline = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            
            for (int i = 0; i< number.Length; i++)
            {

            }
        }
    }
}

