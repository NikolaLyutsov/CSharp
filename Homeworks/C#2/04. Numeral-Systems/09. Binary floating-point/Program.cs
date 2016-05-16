//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format 
//(the C# type float).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Binary_floating_point
{
    class Program
    {
        static void Main()
        {
            float toDisplayInput = float.Parse(Console.ReadLine());

            float toDisplay = toDisplayInput;
            string toPrint = "";
            string[] BinKey = "0 1".Split(' ');
            string SignString = "0";

            if (toDisplayInput < 0)
            {
                SignString = "1";
                toDisplay = Math.Abs(toDisplay);
            }
            
            int powCounter = 0;

            while (!(toDisplay >= 1 && toDisplay < 2))
            {
                toDisplay /= 2;
                powCounter++;
            }
            
            float Number = toDisplay - 1;

            string NumString = "";
            
            while (Number != 0 &&
                   NumString.Length <= 23)
            {
                Number *= 2;

                if (Number >= 1)          
                {                        
                    NumString += "1";  
                    Number -= 1;         
                }                    
                else
                {       
                    NumString += "0";   
                }                        
            }
            NumString = NumString.PadRight(23, '0');
            
            int Power = 127 + powCounter;

            string PowString = Convert.ToString(Power, 2);
            
            PowString = PowString.PadLeft(8, '0');
            
            toPrint = SignString + PowString + NumString;

            Console.WriteLine(toPrint);
        }
    }
}
