using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert num1");
            Console.WriteLine("please insert +, -, *,/ as operators!");
            Console.WriteLine("please insert num2");

            string strnum1, opera, strnum2;
            strnum1 = Console.ReadLine();
            opera = Console.ReadLine();
            strnum2 = Console.ReadLine();
            double num1, num2;
            num1 = double.Parse(strnum1);
            num2 = double.Parse(strnum2);

            switch (opera)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

            }


            Console.ReadKey();
        }
    }
}
