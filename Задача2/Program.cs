//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number2 == number1 * number1)
// {
//     Console.WriteLine("да: ");
// }
// else
// {
//     Console.WriteLine("нет: ");
// }

//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//1 вариант решения - мой
// Console.WriteLine("Введите номер: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1 == 3)
// {
//     Console.WriteLine("Среда: ");
// }

// else 
// {
//     Console.WriteLine("Пятница: ");
// }

//2 вариант решения
//  Console.WriteLine("Ведите номер для недели");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1 == 1)
// {
//     Console.WriteLine("Понедельник");
// }       

// if (number1 == 2)
// {
//     Console.WriteLine("Вторник");
// }    

// if (number1 == 3)
// {
//     Console.WriteLine("Среда");
// }       
             
// if (number1 == 4)
// {
//     Console.WriteLine("Четверг");
// }  

// if (number1 == 5)
// {
//     Console.WriteLine("Пятница");
// }  

// if (number1 == 6)
// {
//     Console.WriteLine("Суббота");
// } 

// if (number1 == 7)
// {
//     Console.WriteLine("Воскресенье");
// } 

//3 вариант решения
 Console.WriteLine("Ведите номер  от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Понедельник");
}       

else if (day == 2)
{
    Console.WriteLine("Вторник");
}    

else if (day == 3)
{
    Console.WriteLine("Среда");
}       
             
else if (day == 4)
{
    Console.WriteLine("Четверг");
}  

else if (day == 5)
{
    Console.WriteLine("Пятница");
}  

else if (day == 6)
{
    Console.WriteLine("Суббота");
} 

else if (day == 7)
{
    Console.WriteLine("Воскресенье");
} 
