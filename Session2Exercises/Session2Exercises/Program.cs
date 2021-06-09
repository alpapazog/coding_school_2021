using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Exercises {
    class Program {
        static void Main(string[] args) {

            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question6();
            //Question7();
            //Question8();
            //Question9();
            //Question10();

            Console.ReadLine();
        }

        static void Question1() {
            Console.WriteLine("\nQuestion1");
            Console.WriteLine("Hello World and Alexis Papazoglou");
        }

        static void Question2() {
            Console.WriteLine("\nQuestion2");

            Console.Write("x = ");
            decimal x = Convert.ToDecimal(Console.ReadLine());

            Console.Write("y = ");
            decimal y = Convert.ToDecimal(Console.ReadLine());

            decimal sum = x + y;
            decimal ratio = x/y;
            Console.WriteLine("x+y = " + sum + "\nx/y = " + ratio);
        }

        static void Question3() {
            Console.WriteLine("\nQuestion3");

            decimal result1 = -1 + 5 * 6;
            decimal result2 = 38 + 5 % 7;
            decimal result3 = 14 - 3 * 6m/7;
            decimal result4 = 2 + 13m / 6 * 6 + Convert.ToDecimal(Math.Sqrt(7));
            decimal result5 = (Convert.ToDecimal(Math.Pow(6,4)) + Convert.ToDecimal((Math.Pow(5, 7)))) / (9%4);

            Console.WriteLine("-1 + 5 * 6 = " + result1);
            Console.WriteLine("38 + 5mod7 = " + result2);
            Console.WriteLine("14 + (-3 * 6/7) = " + result3);
            Console.WriteLine("2 + (13/6) * 6 + \u221A 7 = " + result4);
            Console.WriteLine("(6^4 + 5^7) / 9mod4 = " + result5);

        }

        static void Question4() {
            Console.WriteLine("\nQuestion4");

            Console.Write("x = ");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.Write("y = ");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Console.Write("z = ");
            decimal z = Convert.ToDecimal(Console.ReadLine());

            decimal product = x * y * z;

            Console.WriteLine("x*y*z = " + product);
        }

        static void Question5() {
            Console.WriteLine("\nQuestion5");

            Console.WriteLine("Type in 5 numbers seperated by spaces: ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            decimal number1 = decimal.Parse(data[0]);
            decimal number2 = decimal.Parse(data[1]);
            decimal number3 = decimal.Parse(data[2]);
            decimal number4 = decimal.Parse(data[3]);
            decimal number5 = decimal.Parse(data[4]);


            decimal mean = (number1 + number2 + number3 + number4 + number5)/ 5;
            Console.WriteLine("average = " + mean);
        }

        static void Question6() {
            Console.WriteLine("\nQuestion6");

            Console.Write("Age: ");
            string age = Console.ReadLine();

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.WriteLine("You are " + gender + " and look younger than " + age);
        }

        static void Question7() {
            Console.WriteLine("\nQuestion7");

            Console.Write("Seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            int years = seconds / (60 * 60 * 24 * 365);
            int days = seconds / (60 * 60 * 24)-years*365;
            int hours = seconds / (60 * 60) - years*365*24 - days*24;
            int minutes = seconds / 60 - years * 365 * 24*60 - days * 24*60 - hours*60;

            Console.WriteLine(seconds + " seconds are equal to " + years + " years " + days + " days " + hours + " hours and " + minutes + " minutes");
        }

        static void Question8() {
            Console.WriteLine("\nQuestion8");

            Console.Write("Seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(seconds);
            int years = time.Days / 365;
            int days = time.Days - years * 365;        
            string str = time.ToString(@"hh\:mm");

            Console.WriteLine(years + ":" + days + ":" + str + " (years:days:hours:minutes)");
        }

        static void Question9() {
            Console.WriteLine("\nQuestion9");

            Console.Write("Temperature in Celsius: ");
            int temperatureCelsius = Convert.ToInt32(Console.ReadLine());

            int temperatureKelvin = temperatureCelsius + 273;
            int temperatureFahrenheit = (int) (1.8 * temperatureCelsius + 32);

            Console.WriteLine(temperatureCelsius + " Celsius = " + temperatureFahrenheit + " Fahrenheit = " + temperatureKelvin + " Kelvin");
        }

        static void Question10() {
            Console.WriteLine("\nQuestion10");

            Console.Write("Type anything: ");
            string str = Console.ReadLine();

            string newStr = String.Join("", str.Split('a'));

            Console.WriteLine(newStr);
        }
    }
}
