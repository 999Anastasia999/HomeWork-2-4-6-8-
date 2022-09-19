using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
        //Напишите программу, которая на вход принимает число и выдаетего квадрат (число умноженное на само себя).
        //тип_данных имя_переменной = значение_переменной;
        //Console.WriteLine("Введите число");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = a * a;
        //Console.WriteLine($"{a} * {a} = {b}");

        //ветвление 
        //если (на улице дождь),  //условие
        //     (то возьми зонтик) //действие1
        //иначе
        //     (иди в садалях)    //действие2
        //int rain = 0; //0 - не идет дождь, 1 - идет дождь
        //if (rain == 1)
        //{
        //    Console.WriteLine("возьми зонт");
        //}
        //else
        //{
        //    Console.WriteLine("можешь идти в сандалях");
        //}

        //цикл
        //пока время раннее, можно смотреть мультики
        int time = 11;
        while(time < 22)
        {
            time++;
            Console.WriteLine("еще можно смотреть мультики. время: " + time);
        }
        Console.WriteLine("пора спать");
        Console.WriteLine(time);

        }

        #region Fill and Print
        
    }
}
#endregion