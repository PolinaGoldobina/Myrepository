//Задание 1.
/*
using System; 
using System.IO; 
 
class Program 
{ 
    static void Main() 
    { 
        string[] lines = File.ReadAllLines("input.txt"); 
        string[] chosenNumbers = lines[0].Split(' '); 
 
        int n = int.Parse(lines[1]); 
        string[] tickets = new string[n]; 
 
        for (int i = 0; i < n; i++) 
        { 
            string[] ticketNumbers = lines[i + 2].Split(' '); 
            int count = 0; 
 
            for (int j = 0; j < 6; j++) 
            { 
                if (Array.IndexOf(chosenNumbers, ticketNumbers[j]) != -1) 
                { 
                    count++; 
                } 
            } 
            if (count >= 3) 
            { 
                tickets[i] = "Lucky"; 
            } 
            else 
            { 
                tickets[i] = "Unlucky"; 
            } 
        } 
 
        File.WriteAllLines("output.txt", tickets); 
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
        string filePath = "nums.txt";
        string[] numbers = File.ReadAllText(filePath).Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            if (int.Parse(numbers[i]) % 2 == 0)
            {
                numbers[i] = "";
            }
        }

        string result = string.Join(" ", numbers);
        File.WriteAllText(filePath, result);
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
        string filePath = "input.txt";

        using (StreamReader sr = new StreamReader(filePath))
        {
            string line = sr.ReadLine();
            string[] numbers = line.Split(' ');

            int[] height = Array.ConvertAll(numbers, int.Parse);

            int maxArea = 0;

            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < height.Length; i++)
                {
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        int h = Math.Min(height[i], height[j]);
                        int w = j - i;
                        int area = h * w;

                        if (area > maxArea)
                        {
                            maxArea = area;
                            sw.WriteLine(area);
                        }
                    }
                }
            }
        }
    }
}
*/
