﻿//Задание 1.
/*
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "numsTask1.txt";
        int[] numbers = ReadNumbersFromFile(fileName);
        int minIndex = FindMinIndex(numbers);
        // Вычисляем произведение элементов после минимального числа
        int product = CalculateProduct(numbers, minIndex + 1, numbers.Length - 1);

        Console.WriteLine("Произведение элементов после минимального числа: " + product);
    }
    static int[] ReadNumbersFromFile(string fileName)
    {
        return File.ReadAllText(fileName)
            .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
    static int FindMinIndex(int[] numbers)
    {
        int minIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }
    static int CalculateProduct(int[] numbers, int start, int end)
    {
        int product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}
*/

//Задание 2.
/*
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string fileName = "numsTask2.txt";
        string[] lines = File.ReadAllLines(fileName);

        // Разбиваем строку по разделителю ";" и преобразуем в числа
        double[] numbers = lines[0].Split(';')
            .Select(double.Parse)
            .ToArray();
        Array.Sort(numbers);
        // Преобразуем числа обратно в строку с разделителем ";"
        string result = string.Join(";", numbers);
        File.WriteAllText(fileName, result);
    }
}
*/

//Задание 3.
/*
using System;using System.IO;
using System.Linq;
class Program
{
    static void Main(string[] args)    
    {
        string filePath = "numsTask3.txt";
        int[] numbers = File.ReadAllLines(filePath)
            .Select(int.Parse)            
            .ToArray();
        int minIndex = Array.IndexOf(numbers, numbers.Min()); 
        long sum = 0;
        for (int i = 0; i < minIndex; i++)        
        {
            sum += numbers[i];
        }
        double average = (double)sum / minIndex;
        Console.WriteLine($"Среднее арифметическое элементов до минимального числа: {average}");
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
        string fileName = "numsTask4.txt";
        int sum = 0;
        string[] lines = File.ReadAllLines(fileName);
        
        int maxNumber = int.MinValue;
        foreach (string line in lines)
        {
            int number = int.Parse(line);
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        // Вычисление суммы элементов, отличающихся от максимального на 1
        foreach (string line in lines)
        {
            int number = int.Parse(line);
            if (Math.Abs(number - maxNumber) == 1)
            {
                sum += number;
            }
        }
        Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
    }
}
*/

//Задание 5.
/*
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = File.ReadAllLines("numsTask5.txt")
            .Select(int.Parse)
            .ToArray();
        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int maxIndex = Array.IndexOf(numbers, numbers.Max());
        int startIndex, endIndex;
        if (maxIndex < minIndex)
        {
            startIndex = maxIndex;
            endIndex = minIndex;
        }
        else
        {
            startIndex = minIndex;
            endIndex = maxIndex;
        }

        // Вычисляем сумму и количество чисел в диапазоне
        int sum = 0;
        int count = 0;
        for (int i = startIndex + 1; i < endIndex; i++)
        {
            sum += numbers[i];
            count++;
        }

        double average = (double)sum / count;
        Console.WriteLine($"Среднее арифметическое чисел между минимальным и максимальным элементами: {average}");
    }
}
*/