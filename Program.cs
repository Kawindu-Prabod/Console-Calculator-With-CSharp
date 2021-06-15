using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double fn;
            double sn;
            double ans;
            string opr;

            Console.WriteLine("Calculator");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter First No:-");
            fn = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator('+' , '-' , '*' , '/') :-");
            opr = Console.ReadLine();
            Console.WriteLine("Enter Second No:-");
            sn = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if(opr == "+")
            {
                ans = fn + sn;
                Console.WriteLine("=" + ans);
            }

            if (opr == "-")
            {
                ans = fn - sn;
                Console.WriteLine("=" + ans);
            }

            if (opr == "*")
            {
                ans = fn * sn;
                Console.WriteLine("=" + ans);
            }

            if (opr == "/")
            {
                ans = fn / sn;
                Console.WriteLine("=" + ans);
            }



            Console.ReadKey();
        }
    }
}
