using System;

namespace Calculator_Day_02
{
    class Program
    {
       
        public static double Add(double fn, double sn)
        {
            double ans = fn + sn;
            return ans;
        }

        public static double Substract(double fn,double sn)
        {
            double ans = fn - sn;
            return ans;
        }

        public static double Multiplicate(double fn, double sn)
        {
            double ans = fn * sn;
            return ans;
        }

        public static double Divide(double fn, double sn)
        {
            double ans = fn / sn;
            return ans;
        }
        static void Main(string[] args)
        {
            double fn;
            double sn;
            double ans;
            int opr;

            Console.WriteLine("Calculator");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter First No:-");
            fn = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator (1:- '+' ,2:- '-' ,3:- '*' ,4:- '/') :-");
            opr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No:-");
            sn = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            ans = 0;

            switch (opr)
            {
                case 1:
                    {
                        ans = Add(fn, sn);
                        break;
                    }

                case 2:
                    {
                        ans = Substract(fn, sn);
                        break;
                    }

                case 3:
                    {
                        ans = Multiplicate(fn, sn);
                        break;
                    }

                case 4:
                    {
                        ans = Divide(fn, sn);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.WriteLine("=" + ans);
            Console.ReadKey();
        }
    }
}
