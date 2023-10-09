using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Title="Программа №1(Цвигуненко,Лебедева)";
            //int year;
            //Console.WriteLine("Введите год:");
            //year = Convert.ToInt32(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine($"{year}год - високосный");
            //}
            //else
            //{
            //    Console.WriteLine($"{year}год - невисокосный");
            //}
            //Console.ReadKey();

            //Console.Title = "Программа №2(Цвигуненко,Лебедева)";
            //int price;
            //Console.WriteLine("введите цену ноутбука:");
            //price = Convert.ToInt32(Console.ReadLine());
            //if(price>=20000 & price<=30000)
            //    {
            //    Console.WriteLine($"price: входит в диапозон!");
            //    }
            //else
            //{
            //    Console.WriteLine($"price: не входит в диапозон!");
            //}
            //Console.ReadKey();

            //Console.Title = "Программа №3(Цвигуненко,Лебедева)";
            //byte score;
            //Console.WriteLine("Введите балл учащегося:");
            //score = Convert.ToByte(Console.ReadLine());
            //if(score >= 0 && score <= 59)
            //{
            //    Console.WriteLine($"Неудовлетворительно");
            //}
            //else if(score >=60 && score <=74)
            //{
            //    Console.WriteLine($"Удовлетворительно");
            //}
            //else if (score >= 75 && score <= 89)
            //{
            //    Console.WriteLine($"Хорошо");
            //}
            //else if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine($"Отлично");
            //}
            //Console.ReadKey();

            //Console.Title = "Программа №4(Цвигуненко,Лебедева)";
            //string svetofor;
            //Console.Write("Введите состояние светофора:");
            //svetofor = Convert.ToString(Console.ReadLine());
            //switch(svetofor)
            //{
            //    case "1":Console.WriteLine("Красный"); break;
            //    case "2": Console.WriteLine("Желтый"); break;
            //    case "3": Console.WriteLine("Зеленый"); break;
            //    default:Console.WriteLine("ошибка");break;
            //}
            //Console.ReadKey();

            Console.Title = "Программа №5(Цвигуненко,Лебедева)";
            int number;
            Random run = new Random();
            number = run.Next(-5, 5);
            Console.WriteLine(number);
            if(number%2==0)
            {
                Console.WriteLine($"Четное");
            }
            else
            {
                Console.WriteLine($"Нечетное");
            }
            Console.ReadKey();

        }
    }
}
