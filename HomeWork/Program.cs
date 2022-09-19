using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
            //какое число большее, а какое меньшее.
            Console.Write("Введите число1: ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите число2: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 
            if (num2 > num)
            {
                Console.Write("Ответ: второе число больше первого");       
            }

            else if (num2 < num)
            {
                Console.Write("Ответ: первое число больше второго");
            }

            else
            {
                Console.Write("Ответ: числа равны");
            } 
        }

        #region Fill and Print
        
    }
}
#endregion