using System;

namespace Module1
{
    internal class Program
    {
        /////Завдання №1
        /////Користувач вводить з клавіатури число від 1 до 100.
        ////Якщо число кратне 3 (ділиться на 3 без залишку), потрібно
        ////вивести слово Fizz.Якщо число кратне 5, потрібно вивести
        ////слово Buzz.Якщо число кратне 3 і 5, потрібно вивести Fizz
        ////Buzz. Якщо число не кратне ні 3, ані 5, потрібно вивести
        ////тільки число.
        ////Якщо користувач ввів значення не в діапазоні від 1
        ////до 100, потрібно вивести повідомлення про помилку.

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Please enter number");
        //    int num = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine($"you enter number: {num}");

        //    switch (num)
        //    {
        //        case >= 1 and <= 100:
        //            if (num % 3 != 0 && num % 5 != 0)
        //                Console.WriteLine("Fizz Buzz");
        //            else if (num % 3 != 0)
        //                Console.WriteLine("Fizz");
        //            else if (num % 5 != 0)
        //                Console.WriteLine("Buzz");
        //            break;
        //        default:
        //            Console.WriteLine("Error! Acepted diapazone is 1 to 100");
        //            break;
        //    }

        //}
        /*кінець завдання 1*/


        /////Завдання №2
        ////        Користувач вводить з клавіатури два числа.Перше
        ////число — це значення, друге число — відсоток, який не-
        ////обхідно підрахувати. Наприклад, ми ввели з клавіатури
        ////90 і 10. Потрібно вивести на екран 10 відсотків від 90.
        ////Результат: 9.
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"you enter number: {num}");

            switch (num)
            {
                case >= 1 and <= 100:
                    if (num % 3 != 0 && num % 5 != 0)
                        Console.WriteLine("Fizz Buzz");
                    else if (num % 3 != 0)
                        Console.WriteLine("Fizz");
                    else if (num % 5 != 0)
                        Console.WriteLine("Buzz");
                    break;
                default:
                    Console.WriteLine("Error! Acepted diapazone is 1 to 100");
                    break;
            }

        }
        /*кінець завдання 2*/
    }
}
