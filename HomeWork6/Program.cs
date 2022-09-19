using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
            //является ли число четным (делится ли оно на два без остатка).
            Console.Write("Введите число1: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string Answer = "";           
            if (num % 2 == 0)
            {
                Answer = "четное";
            }
            else
            {
                Answer = "нечетное";
            }

            Console.Write("Ответ: введенное число " + Answer);  
        }

        #region Fill and Print
        
    }
}
#endregion
