using System;
using System.Diagnostics;

namespace euler_power
{
    class Program
    {
        static double Exponential_stack(int n, double x)
        {
            Boolean minus = false;
            if (x < 0) { x = -x; minus = true; }
            double sum = 1;

            for (int i = n - 1; i > 0; --i)
                sum = 1 + x * sum / i;
            
            if (minus)
                sum = 1 / sum;
                
            return sum;
        }

        static double Exponential_My_Improved(int n, double x)
        {
            Boolean minus = false;
            if (x < 0) { x = -x; minus = true; }

            double sum = 1 + x;
            long factorial = 1;
            double power = x;
            for (int i = 2; i < n; i++)
            {
                factorial *= i;
                power *= x;
                sum += power / factorial;
            }

            if (minus)
                sum = 1 / sum;
                
            return sum;
        }

        static double Exponential_My_Improved_Factorial(int n, double x)
        {
            Boolean minus = false;
            if (x < 0) { x = -x; minus = true; }

            double sum = 1;
            long factorial = 1;

            for (int i = 1; i < n; i++)
            {
                factorial *= i;
                sum += Math.Pow(x, i) / factorial;
            }

            if (minus)
                sum = 1 / sum;
                
            return sum;
        }

        static double Exponential_My(int n, double x)
        {
            Boolean minus = false;
            if (x < 0) { x = -x; minus = true; }

            double sum = 1;

            for (int i = 1; i < n; i++)
                sum += Math.Pow(x, i) / Factorial(i);

            if (minus)
                sum = 1 / sum;

            return sum;
        }

        static long Factorial(int number)
        {
            if (number < 2)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        static int First_N_Places(int n, double x)
        {
            while(true)
            {
                if (x >= Math.Pow(10, n))
                    x /= 10;
                else if (x < Math.Pow(10, n - 1))
                    x *= 10;
                else 
                    break;
            }
            return (int) x;
        }

        static void Main(string[] args)
        {
            long testIterations = 10000000;

            Console.Write("\nNapište hodnotu mocniny kterou pocitame ");
            double x = Double.Parse(Console.ReadLine());

            for(int i = 0; i < 30;i++)
            {
                Console.WriteLine(Exponential_stack(i, 10));
            }
            return;
            int iteration = 0;
            while(true)
            {
                if (First_N_Places(5, Math.Exp(x)) == First_N_Places(5, Exponential_stack(iteration, x)))
                    break;
                iteration++;
            }
            double result = 0; ;
            Console.WriteLine("Počet iterací: " + iteration);
            var watch = Stopwatch.StartNew();
            for (long i = 0; i < testIterations; i++)
                Math.Exp(x);
            watch.Stop();
            result = Math.Exp(x);
            Console.WriteLine("");
            Console.WriteLine("Math.exp");
            Console.WriteLine("Doba= " + watch.ElapsedMilliseconds);
            Console.WriteLine("vysledek= " + result);
            Console.WriteLine("");

            watch.Restart();
            for (long i = 0; i < testIterations; i++)
                Exponential_stack(iteration, x);
            watch.Stop();
            result = Exponential_stack(iteration, x);
            Console.WriteLine("");
            Console.WriteLine("GeekForGeek");
            Console.WriteLine("Doba= " + watch.ElapsedMilliseconds);
            Console.WriteLine("vysledek= " + result);
            Console.WriteLine("");

            watch.Restart();
            for (long i = 0; i < testIterations; i++)
                Exponential_My_Improved(iteration, x);
            watch.Stop();
            result = Exponential_My_Improved(iteration, x);
            Console.WriteLine("");
            Console.WriteLine("Moje vylespena verze");
            Console.WriteLine("Doba= " + watch.ElapsedMilliseconds);
            Console.WriteLine("vysledek= " + result);
            Console.WriteLine("");

            watch.Restart();
            for (long i = 0; i < testIterations; i++)
                Exponential_My_Improved_Factorial(iteration, x);
            watch.Stop();
            result = Exponential_My_Improved_Factorial(iteration, x);
            Console.WriteLine("");
            Console.WriteLine("Moje verze s pouze vylepsenym faktorialem");
            Console.WriteLine("Doba= " + watch.ElapsedMilliseconds);
            Console.WriteLine("vysledek= " + result);
            Console.WriteLine("");

            watch.Restart();
            for (long i = 0; i < testIterations; i++)
                Exponential_My(iteration, x);
            watch.Stop();
            result = Exponential_My(iteration, x);
            Console.WriteLine("");
            Console.WriteLine("Hloupá verze");
            Console.WriteLine("Doba= " + watch.ElapsedMilliseconds);
            Console.WriteLine("vysledek= " + result);
            Console.WriteLine("");
        }
    }
}
