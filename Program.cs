using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Intrinsics.X86;

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
        ////Користувач вводить з клавіатури два числа.Перше
        ////число — це значення, друге число — відсоток, який не-
        ////обхідно підрахувати. Наприклад, ми ввели з клавіатури
        ////90 і 10. Потрібно вивести на екран 10 відсотків від 90.
        ////Результат: 9.

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Please enter number");
        //    float num = float.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter percent which need calculete");
        //    float percent = float.Parse(Console.ReadLine());
        //    float result = (num * percent) / 100;
        //    Console.WriteLine($"{percent}% at {num} = {result}");
        //}

        /*кінець завдання 2*/



        /////Завдання №3
        /////Користувач вводить з клавіатури чотири цифри.Не-
        ////обхідно створити число, яке містить ці цифри. Напри-
        ////клад, якщо з клавіатури введено 1, 5, 7, 8 тоді потрібно
        ////сформувати число 1578.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter 1 number");
        //    int num1 = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Please enter 2 number");
        //    int num2 = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Please enter 3 number");
        //    int num3 = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("Please enter 4 number");
        //    int num4 = Int32.Parse(Console.ReadLine());

        //    string result = num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString();

        //    Console.WriteLine($"Result is = {result}");
        //}

        /*кінець завдання 3*/


        /////Завдання №4
        ////Користувач вводить шестизначне число.Потім, ко-
        ////ристувач вводить номери розрядів для заміни цифр.
        ////Наприклад, якщо користувач ввів 1 і 6 — це означає, що
        ////треба поміняти місцями першу та шосту цифри.
        ////Число 723895 має перетворитися на 523897.
        ////Якщо користувач ввів не шестизначне число, потрібно
        ////вивести повідомлення про помилку.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter number (XXXXXX)");
        //    int num = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine($"Entered number: {num}");

        //    if (num >= 100000 && num <= 999999)
        //    {
        //        Console.WriteLine("Please enter discharge 1");
        //        int num1 = Int32.Parse(Console.ReadLine());

        //        if(num1 < 1 || num1 > 6)
        //        {
        //            Console.WriteLine("discharge num");
        //            return;
        //        }

        //        Console.WriteLine("Please enter discharge 2");
        //        int num2 = Int32.Parse(Console.ReadLine());

        //        if (num2 < 1 || num2 > 6)
        //        {
        //            Console.WriteLine("discharge num");
        //            return;
        //        }

        //        num1--;
        //        num2--;

        //        char[] temp = num.ToString().ToCharArray();

        //        char temp1 = temp[num1];
        //        char temp2 = temp[num2];

        //        temp[num1] = temp2;
        //        temp[num2] = temp1;

        //        Console.WriteLine("Result is:");
        //        Console.WriteLine(temp);

        //    }
        //    else
        //        Console.WriteLine("Wrong number");


        //}

        /*кінець завдання 4*/


        /////Завдання №5
        //Користувач вводить з клавіатури дату.Додаток має
        //відобразити назву пори року і дня тижня.Наприклад,
        //якщо введено 22.12.2021, додаток має відобразити Winter
        //Wednesday.

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Please enter date in format 22.12.2021 (day.month.year)");
        //    string temp = Console.ReadLine();

        //    int daytime = Int32.Parse(temp.Replace(".", ""));
        //    int day = daytime / 1000000;
        //    int month = (daytime / 10000) % 100;
        //    int year = daytime % 10000;

        //    DateTime dTime = new DateTime(year, month, day);

        //    if(month>=3 && month <=5)
        //        Console.WriteLine("Spring");
        //    else if(month >= 6 && month <= 8)
        //        Console.WriteLine("Summer");
        //    else if (month >= 9 && month <= 11)
        //        Console.WriteLine("Autum");
        //    else
        //        Console.WriteLine("Winter");

        //    Console.WriteLine(dTime.DayOfWeek);
        //}

        /*кінець завдання 5*/


        /////Завдання №6
        //Користувач вводить з клавіатури показання темпера-
        //тури.Залежно від вибору користувача, додаток конвертує
        //температуру з Фаренгейта в Цельсій, або навпаки.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Choise your input date Celsium or Farenheit (c or f)");

        //   string input = (Console.ReadLine());
        //   char ch = input[0];

        //    Console.WriteLine("Enter number which you see on thermometer");
        //    float num = float.Parse(Console.ReadLine());

        //    if (ch == 'c')
        //    {
        //        num += 32;
        //        Console.WriteLine($"you num in farenheit {num}");
        //    }
        //    else if (ch == 'f')
        //    {
        //        num -= 32;
        //        Console.WriteLine($"you num in celsiun {num}");
        //    }

        //}

        /*кінець завдання 6*/

        /////Завдання №7
        ///////Користувач вводить з клавіатури два числа. Потріб-
        ////но показати усі парні числа у вказаному діапазоні.Якщо
        ////межі діапазону вказані неправильно, потрібно провести
        ////нормалізацію кордонів. Наприклад, користувач ввів 20 і
        ////11. Потрібна нормалізація, після якої початок діапазону
        ////дорівнюватиме 11, а кінець дорівнюватиме 20.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number of diapazone");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter two number of diapazone");
            int num2 = Int32.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                int temp = num2;
                num2 = num1;
                num1 = temp;
            }

            Console.WriteLine("Output range");
            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    Console.Write(i);
                    Console.Write(' ');
                }  
            }
        }

        /*кінець завдання 7*/
    }
}
