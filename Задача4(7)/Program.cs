using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая на вход принимает одно число (N), 
            // а на выходе показвает все целые числа в промежутке от -N до N/
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            num = Math.Abs(num);
            int num2 = -num;
            while (num2 <= num)
            {
                Console.Write(num2 + ",");
                num2 = num2 + 1;
            }
            //Console.WriteLine("\b\b\b\b");
            Console.WriteLine();
        }

        #region Fill and Print
        
    }
}
#endregion