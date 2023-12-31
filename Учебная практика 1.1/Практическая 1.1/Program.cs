﻿//Задание 1. 
/*
using System;
class Program
{
    static void Main()
    {
        Random rndl = new Random();
        int[] nums = new int[10];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rndl.Next();
        }

        int minElement = nums[0];
        int minIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < minElement)
            {
                minElement = nums[i];
                minIndex = i;
            }
        }

        Console.WriteLine("Номер минимального элемента: " + minIndex);
    }
} 
*/
    
//Задание 2
/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int i;

        do
        {
            Console.Write("Введите число (для завершения введите 0): ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i != 0)
            {
                numbers.Add(i);
            }
        } while (i != 0);

        int sum = 0;
        int product = 1;
        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
        }

        float average = (float)sum / numbers.Count;

        Console.WriteLine("Сумма чисел: " + sum);
        Console.WriteLine("Произведение чисел: " + product);
        Console.WriteLine("Среднее: " + average);
    }
}
*/

//Задание 3
/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> elements = new List<string>();
        string input;

        do
        {
            Console.Write("Введите элемент (для завершения оставьте строку пустой): ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) 
            {
                elements.Add(input);
            }
        } while (!string.IsNullOrEmpty(input));

        string shortest = "";
        string longest = "";

        if (elements.Count > 0)
        {
            shortest = elements[0];
            longest = elements[0];

            foreach (string element in elements)
            {
                if (element.Length < shortest.Length)
                {
                    shortest = element;
                }
                if (element.Length > longest.Length)
                {
                    longest = element;
                }
            }
        }

        Console.WriteLine("Самый короткий элемент: " + shortest);
        Console.WriteLine("Самый длинный элемент: " + longest);
    }
}
*/

//Задание 4
/*
using System;

class Program
{
    static void Main()
    {
        int start = 1; // начало диапазона
        int end = 10; // конец диапазона

        int[] GenerateRandomArray(int begin, int finish)
        {
            Random rnd = new Random();
            int[] array = new int[10]; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(begin, finish + 1); 
            }
            return array;
        }

        int[] randomArray = GenerateRandomArray(start, end);

        foreach (int num in randomArray)
        {
            Console.Write(num + " "); 
        }
    }
}
*/

//Задание 5
/*
using System;

class Program
{
static void Main()
{
Console.Write("Введите строку: ");
string input = Console.ReadLine();
string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // разбиваем строку на слова
int wordCount = words.Length; 
string result = "Start " + input + " End"; 
Console.WriteLine("Количество слов: " + wordCount);
Console.WriteLine("Результат: " + result);
}
}
*/