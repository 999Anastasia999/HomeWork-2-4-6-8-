using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 8: Напишите программу, которая на вход принимает число (N > 0),
            //а на выходе показывает все четные числа от 1 до N.
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string Answer = "";
            string Sep = ""; 
            int count = 1;          
            if (N > 0)
            {
                while (count<=N)
                {
                    if (count % 2 == 0)
                    {
                       if (count == N) {Sep = ".";} else {Sep = ", ";}
                       Answer = Answer + count + Sep;
                    }                                  
                 
                 //Console.WriteLine("Answer - " + Answer + "; count - " + count);
                 count = count + 1;                 
                }
                Console.WriteLine("Ответ: все четные числа от 1 до " + N + ": " + Answer +""); 
                  
            }
            else 
            {
                Console.Write("Ответ: введенное число не отвечает заданному условию (N > 0)");
            }
                
        }

        #region Fill and Print
        
    }
}
#endregion

