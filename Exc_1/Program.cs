using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор v0.01");
            Console.Write("Введите целое число: x = ");
            int x = ConvNum(Console.ReadLine());
            Console.Write("Введите целое число: y = ");
            int y = ConvNum(Console.ReadLine());
            CalcIt(x, y);
            Console.ReadKey();
        }
        static void CalcIt(int x, int y)
        {
            Console.Write("Выберите действие '+', '-', '*', '/' : ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "+":
                    Console.Write($"{x} + {y} = {x + y}");
                    break;
                case "-":
                    Console.Write($"{x} - {y} = {x - y}");
                    break;
                case "*":
                    Console.Write($"{x} * {y} = {x * y}");
                    break;
                case "/":
                    try
                    {
                        Console.Write($"{x} / {y} = {x / y}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Ошибка. Деление на ноль.");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка. Выбрана неверная команда");
                    CalcIt(x, y);
                    break;
            }
        }
        static int ConvNum (string a)
        {
            try
            {
                return Convert.ToInt32(a);
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Ошибка. {exc.Message}");
                Console.Write("Повторите ввод: ");
                a = Console.ReadLine();
                return ConvNum(a);
            }
        }
    }
}
