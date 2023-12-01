//Задание 1.
/*
using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[100];

        int value = 100;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = value;
            value -= 3;
        }

        Console.WriteLine("Полученная коллекция:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}  
*/

//Задание 2.
/*
using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        
        int value = 1; 
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = value;
            value += 2; 
        }
        Console.WriteLine("Полученная коллекция:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
*/

//Задание 3.
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер матрицы n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            matrix[i, 0] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        Console.WriteLine("Матрица: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
*/

//Задание 4.
/*
using System;
class Program
{
    static void Main()
    {
        int[,] temperatures = new int[12, 30];
        Random rndl = new Random();
        
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = rndl.Next(-40, 40); 
            }
        }
        int[] averageTemperatures = CalculateAverageTemperatures(temperatures);
        Array.Sort(averageTemperatures);
        foreach (var temp in averageTemperatures)
        {
            Console.WriteLine(temp);
        }
    }
    static int[] CalculateAverageTemperatures(int[,] temperatures)
    {
        int[] averageTemperatures = new int[12];

        for (int month = 0; month < 12; month++)
        {
            int sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperatures[month, day];
            }
            averageTemperatures[month] = sum / 30;
        }

        return averageTemperatures;
    }
}
*/

//Задание 5.
/*
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Создание словаря
        Dictionary<string, int[]> temperatures = CreateTemperatureDictionary();
        // Запрос названия месяца
        Console.WriteLine("Enter the month (in English): ");
        string month = Console.ReadLine().ToLower();

        if (temperatures.ContainsKey(month))
        {
            int[] monthTemperatures = temperatures[month];
// Вывод массива исходных температур
            Console.WriteLine("Temperatures for " + month + ":");
            for (int i = 0; i < monthTemperatures.Length; i++)
            {
                Console.Write(monthTemperatures[i]);
                if (i < monthTemperatures.Length - 1)
                {
                    Console.Write("; ");
                }
            }
            Console.WriteLine();
// Вычисление среднего значения месяца
            double averageTemperature = CalculateAverageTemperature(monthTemperatures);
            Console.WriteLine("Average temperature for " + month + ": " + averageTemperature);
        }
        else
        {
            Console.WriteLine("Month " + month + " not found.");
        }
        Console.ReadLine();
    } 
    static Dictionary<string, int[]> CreateTemperatureDictionary()
    {
        Dictionary<string, int[]> temperatures = new Dictionary<string, int[]>();
// Добавление значений температур для каждого месяца
        temperatures.Add("january", GenerateRandomArray(-50, -10, 30));
        temperatures.Add("february", GenerateRandomArray(-40, -15, 30));
        temperatures.Add("march", GenerateRandomArray(-30, 0, 30));
        temperatures.Add("april", GenerateRandomArray(-20, 10, 30));
        temperatures.Add("may", GenerateRandomArray(-10, 15, 30));
        temperatures.Add("june", GenerateRandomArray(15, 30, 30));
        temperatures.Add("july", GenerateRandomArray(15, 40, 30));
        temperatures.Add("august", GenerateRandomArray(15, 30, 30));
        temperatures.Add("september", GenerateRandomArray(10, 20, 30));
        temperatures.Add("october", GenerateRandomArray(-10, 10, 30));
        temperatures.Add("november", GenerateRandomArray(-20, 0, 30));
        temperatures.Add("december", GenerateRandomArray(-40, -10, 30));
        return temperatures;
    }
    static int[] GenerateRandomArray(int min, int max, int length)
    {
        Random random = new Random();
        int[] array = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        
        return array;
    }

    static double CalculateAverageTemperature(int[] temperatures)
    {
        double sum = 0;
        int count = temperatures.Length;

        foreach (int temperature in temperatures)
        {
            sum += temperature;
        }

        return sum / count;
    }
}
*/ 