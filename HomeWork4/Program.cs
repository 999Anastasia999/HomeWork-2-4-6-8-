using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 4: Напишите программу, которая на вход принимает три числа и выдаёт, 
            //максимальное из этих чисел.
            Console.Write("Введите число1: ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите число2: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введите число3: ");
            int num3 = Convert.ToInt32(Console.ReadLine()); 
            int max_num = num;
            if (num2 > max_num)
            {
                max_num = num2;
            }

            if (num3 > max_num)
            {
                max_num = num3;
            }
            Console.Write("Ответ: максимальное число - найдено " + max_num);  
        }

        #region Fill and Print
        
    }
}
#endregion