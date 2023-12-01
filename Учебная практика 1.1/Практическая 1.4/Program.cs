//Задание 1.
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое положительное число n: ");
        int n = int.Parse(Console.ReadLine());
        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }
        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающих {n}, равно {product}");
    }
}
*/

//Задание 2.
/*
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "numsTask2.txt";
        string fileContents = File.ReadAllText(path);

        string[] numberStrings = fileContents.Split(';');
        double[] numbers = Array.ConvertAll(numberStrings, double.Parse);

        double sum = 0;
        foreach (double number in numbers)
        {
            if (number == 0)
                break;

            if (number > 0)
                sum += number;
        }

        Console.WriteLine("Сумма положительных элементов: " + sum);
    }
}
*/

//Задание 3.
/*
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "numsTask3.txt";
        string fileContents = File.ReadAllText(filePath);

        string[] numberStrings = fileContents.Split(',');
        int[] numbers = Array.ConvertAll(numberStrings, int.Parse);

        int min = int.MaxValue;
        int max = int.MinValue;
        bool foundZero = false;

        foreach (int number in numbers)
        {
            if (number == 0)
            {
                foundZero = true;
                break;
            }
            
            if (number < min)
                min = number;
            
            if (number > max)
                max = number;
        }

        if (foundZero)
        {
            double ratio = (double) min / max;

            Console.WriteLine("Отношение минимального и максимального элементов: " + ratio);
        }
        else
        {
            Console.WriteLine("Файл не содержит нулевого элемента.");
        }
    }
}
*/

//Задание 4.
/*
using System;
using System.IO;
class Program
{
    static void Main()
    {
        // Путь к файлу
        string filePath = "numsTask4.txt";
        {
            string line = File.ReadAllText(filePath);
            // Разделение строки на числа по пробелу
            string[] numbersStr = line.Split(' ');
            int count = 0;
            // Перебор чисел и подсчет одинаковых рядом стоящих чисел
            for (int i = 1; i < numbersStr.Length; i++)
            {
                if (numbersStr[i] == numbersStr[i - 1])
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество одинаковых рядом стоящих чисел: " + count);
        }
    }
}
*/

//Задание 5.
/*
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        double x1 = 3;
        double y1 = 4;
        double y2 = -2;
        double x2 = -1;
        Console.Write("Введите x: ");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = Convert.ToInt32(Console.ReadLine());

        if (x <= x1 && y <= y1 && y >= y2 && x >= x2)
        {
            Console.WriteLine("Точка принадлежит заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит заштрихованной области");
        }
    }
}
*/

//Задание 6.
/*
using System;

class Program
{
    static void Main()
    {
        double y1 = 0;
        double y2 = 2;
        double y3 = -3;
        double x1 = 2;
        double x2 = -2;

        Console.WriteLine("Введите координату а:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координату b:");
        double b = double.Parse(Console.ReadLine());

        if (b >= y1 && b <= y2 && a >= x2 && a <= x1)
        {
            Console.WriteLine("Точка принадлежит заданной области.");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит заданной области.");
        }
    }
}
*/ 