using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{ 
    class Program
{
    
    public static void MathCalculation()
    {
        Console.WriteLine("Напишите число до 10");
        if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 10)
        {
            double summa = 0;
            for (int i = 1; i < 10; i++)
            {
                summa += Math.Pow(x, i) / (x + i);
            }
            Console.WriteLine($"Сумма: {summa}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное число от 1 до 9.");
        }
    }

    static void Main(string[] args)
    {
        MathCalculation();
        Console.ReadKey();
    }
}
}