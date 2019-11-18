using System;

namespace Celsius
{
    class firstExercise
    {
        static void Main(string[] args)
        {
            double celsius;

            Console.Write("Enter Fahrenheit Temp : ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("The converted Celsius Temp is " + celsius);

            Console.ReadLine();
        }
    }
}