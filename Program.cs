using System;

namespace Lab04_SAJAL
{
    class Program
    {

        public static double average(int n1, int n2)
        {
            return (n1 + n2) / 2.0;
        }

        // Overloaded methoid Definition(s) here ...}

        static double average(double a, double b)
        {
            return (a + b) / 2.0;
        }

        static double average(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }

        static double average(double x, double y, double z)
        {
            return (x + y + z) / 3.0;
        }

        public static void Main(String[] args)
        {

            int a = 1, b = 3, c = 5;

            double x = 2.2, y = 4.4, z = 6.6, ans;

            ans = average(a, b);

            Console.WriteLine("\naverage(a, b) = " + ans);

            ans = average(a, b, c);

            Console.WriteLine("\naverge(a, b, c) = " + ans);

            ans = average(x,y);

            Console.WriteLine("\naverage(x, y) = " + ans);

            ans = average(x, y, z);

            Console.WriteLine("\naverage(x, y, z) = " + ans);
        }
        
    }
}


//Answers of the following questions:

//1.Do you really need the int parameter version(s)ofaverage,and why?

//Yes, because we need to refrence what is the name sapce for. definition is nedded to run the code.


//2.Do you really need the three parameter version of average,i.e.  is average(average(a, b),c)== average(a, b, c),and why?

//Yes, The average of 3 different numbers is going to be different than the average of two sup of (mean) numbers
//The average(average(a, b), c) is not the same as average(a, b, c). 


//3.Is average(1,2.0,3)legal,and if so which version is used, and why?

//Yes its a legal process, average(double x, double y, double z) is used because it is the only method that can accept a double argument.
