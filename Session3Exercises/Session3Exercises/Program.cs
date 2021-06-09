using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercises {
    class Program {
        static void Main(string[] args) {

            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question6();

            Console.ReadLine();
        }

        static public void Question1() {
            string sentence = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            string[] stringArray = sentence.Split(' ');

            int max = -1;
            string maxStr = null;
            foreach (string str in stringArray) {
                if (str.Length > max) {
                    max = str.Length;
                    maxStr = str;
                }
            }
            Console.WriteLine(maxStr.ToUpper());
        }
        
        static public void Question2() {
            Console.Write("Input string: ");
            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverseStr = new string(charArray);

            Console.WriteLine(reverseStr);
        }
        
        static public void Question3() {
            Console.Write("Type in an integer n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type in 's' if you want to calculate the sum of 1,...n, or 'p' to calculate the product of 1,...,n: ");
            string inputChoice = Console.ReadLine();

            if (inputChoice == "s") {
                int sum = 0;
                for (int i = 1; i <= n; i++) {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
            else if (inputChoice == "p") {
                int product = 1;
                for (int i = 1; i <= n; i++) {
                    product = product * i;
                }
                Console.WriteLine(product);
            }
        }

        static public void Question4() {
            Console.Write("Type in an integer n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int divisorsCount;

            Console.Write("Prime numbers from 1 to {0}: 1", n);
            for (int i=1; i<n; i++) {

                divisorsCount = 0;
                for (int j = 1; j<i; j++) {
                    if (i % j == 0) {
                        divisorsCount++;
                    }
                }
                if (divisorsCount == 1) {
                    Console.Write(", " + i);
                }
            }

        }

        static public void Question5() {
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            for (int i = 0; i<array1.Length; i++) {
                for (int j = 0; j < array2.Length; j++) {
                    Console.Write("{0}*{1}=", array1[i], array2[j]);
                    
                    int result = array1[i] * array2[j];
                    Console.Write(result + "  ");
                }
                Console.WriteLine();
            }
        }

        static public void Question6() {
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++) {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
