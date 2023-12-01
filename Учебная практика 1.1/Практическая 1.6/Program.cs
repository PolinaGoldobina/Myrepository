//Задание 1.
/*
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask1.txt");
        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word);
            }
        }
    }
}
*/

//Задание 2.
/*
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string[] words = File.ReadAllLines("numsTask2.txt");

        // Составляем одну длинную строку
        string result = string.Join(" ", words);
        Console.WriteLine(result);
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
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine("Число является четным и кратным 10.");
        }
        else
        {
            Console.WriteLine("Число не является четным и/или кратным 10.");
        }

        Console.ReadLine();
    }
}
*/

//Задание 4.
/*
using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int sum = 0;

        while (true)
        {
            Console.Write("Введите число (для завершения введите отрицательное число): ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            if (a == 0)
            {
                Console.Write("Введите положительное число a: ");
                a = int.Parse(Console.ReadLine());

                if (a <= 0)
                {
                    Console.WriteLine("Введено некорректное значение для a.");
                    break;
                }
            }

            if (number % a == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine($"Сумма чисел, делящихся на {a} нацело: {sum}");
    }
}
*/

//Задание 5.
/*
using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 3; // количество строк
        int m = 4; // количество столбцов
        
        int[,] matrix = { { 1, 0, 1, 1 }, { 0, 1, 0, 1 }, { 1, 1, 0, 0 } }; // исходная матрица
        int[,] newMatrix = new int[n, m + 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            int count = 0; // количество единиц в текущей строке
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 1)
                    count++;
            }

            if (count % 2 == 0)
                newMatrix[i, m] = 0; // если количество единиц уже четное
            else
                newMatrix[i, m] = 1; // если количество единиц нечетное
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/

//Задание 6.
/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<double> sourceArray = new List<double>();
        for (int i = 0; i < 10; i++)
        {
            sourceArray.Add(random.NextDouble() * (random.Next(0, 2) == 0 ? -1 : 1));
        }

        List<double> positiveArray = new List<double>();
        List<double> negativeArray = new List<double>();

        // Разбираем исходный массив и размещаем элементы в соответствующих массивах
        foreach (double number in sourceArray)
        {
            if (number > 0)
            {
                positiveArray.Add(number);
            }
            else if (number < 0)
            {
                negativeArray.Add(number);
            }
        }
        Console.WriteLine("Исходный массив:");
        foreach (double number in sourceArray)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n\nМассив положительных элементов:");
        foreach (double number in positiveArray)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n\nМассив отрицательных элементов:");
        foreach (double number in negativeArray)
        {
            Console.Write(number + " ");
        }

        Console.ReadKey();
    }
}
*/