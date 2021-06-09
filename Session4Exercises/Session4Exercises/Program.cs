using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercises {
    class Program {
        static void Main(string[] args) {

            //Question 1, recursive decimal to binary conversion
            const int dec = 128;
            Console.WriteLine(DecimalToBinary(dec));

            //Question 2
            //empty, see classes

            Console.ReadLine();
        }

        static string DecimalToBinary(int dec) {
            
            int remainder = dec % 2;
            string nextDigit = Convert.ToString(remainder);

            if (dec / 2 == 0) {
                return nextDigit;
            }
            
            return string.Format("{1}{0}", nextDigit, DecimalToBinary(dec / 2));

        }
    }
}
