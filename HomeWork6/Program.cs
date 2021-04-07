using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1to4();
            Task5();
            Task6();
            Task7();
        }
        static void Task1to4()
        {
            Console.WriteLine("Task 1 - 4");
            Console.WriteLine("Find Max and Min elements of the array and their indexes");
            int[,] array = new int[5, 5];
            
            FillArray(array);
            Console.WriteLine();
            FindMinElement(array);
            FindMaxElement(array);       
            
        }
        static void Task5()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Task 5");
            Console.WriteLine("Count number of elements that are bigger then their neighbours");
            int[,] array = new int[3, 5];
            FillArray(array);
            FindMaxNeighbour(array);
        }
        static void Task6()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Converting numbers to words");
            Console.WriteLine("Enter number from 0 to 999");
            int number = int.Parse(Console.ReadLine());
            int[] array_int = new int[4];
            array_int[0] = number % 1000;
            string result = " ";
            for (int i = 0; i < 4; i++)
            {
                if (array_int[i] != 0)
                {
                    if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                    {
                        switch (((array_int[i] - (array_int[i] % 100)) / 100))
                        {
                            case 1: result += " one hundred"; break;
                            case 2: result += " two hundred"; break;
                            case 3: result += " three hundred"; break;
                            case 4: result += " four hundred"; break;
                            case 5: result += " five hundred"; break;
                            case 6: result += " six hundred"; break;
                            case 7: result += " seven hundred"; break;
                            case 8: result += " eight hundred"; break;
                            case 9: result += " nine hundred"; break;
                        }
                    }
                    if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                    {
                        switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                        {
                            case 2: result += " twenty"; break;
                            case 3: result += " thirty"; break;
                            case 4: result += " fourty"; break;
                            case 5: result += " fifty"; break;
                            case 6: result += " sixty"; break;
                            case 7: result += " seventy"; break;
                            case 8: result += " eighty"; break;
                            case 9: result += " ninety"; break;
                        }
                    }
                    
                    switch (array_int[i] % 10)
                    {
                        case 1: result += " one"; break;
                        case 2: result += " two"; break;
                        case 3: result += " three"; break;
                        case 4: result += " four"; break;
                        case 5: result += " five"; break;
                        case 6: result += " six"; break;
                        case 7: result += " seven"; break;
                        case 8: result += " eight"; break;
                        case 9: result += " nine"; break;
                    }
                    switch (array_int[i] % 100)
                    {
                        case 10: result += " ten"; break;
                        case 11: result += " eleven"; break;
                        case 12: result += " twelve"; break;
                        case 13: result += " thirteen"; break;
                        case 14: result += " fourteen"; break;
                        case 15: result += " fifteen"; break;
                        case 16: result += " sixteen"; break;
                        case 17: result += " seventeen"; break;
                        case 18: result += " eighteen"; break;
                        case 19: result += " nineteen"; break;
                    }

                }
            }
            Console.WriteLine(result);


        }

        static void Task7()
        {
            Console.WriteLine("=============================================================="); 
            Console.WriteLine("Task 7");
            Console.WriteLine("Convert words to numbers");
            Console.WriteLine("Enter words from 'zero' to 'nine hundred ninety nine' ");

        }

        static void FillArray(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1000);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static void FindMinElement(int[,] array)
        {
            int iMin = 0, jMin = 0;
            int minElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)//row
            {
                for (int j = 0; j < array.GetLength(1); j++)//column
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                        iMin = i;
                        jMin = j;
                    }
                }
            }
            Console.WriteLine($"Max Element in array: {minElement}; Index: {iMin}, {jMin}");
        }

        static void FindMaxElement(int[,] array)
        {
            int iMax = 0, jMax = 0;
            int maxElement = array[iMax, jMax];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }
            Console.WriteLine($"Max Element in array: {maxElement}; Index: {iMax}, {jMax}");            
        }

        static void FindMaxNeighbour(int[,] array)
        {
            int count = 0;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int leftNeighbour = (j == 0) ? 0 : array[i, j - 1]; 
                    int rifghtNeighbour = (j == array.GetLength(1) - 1) ? 0 : array[i, j + 1]; 
                    if (array[i,j] > (leftNeighbour + rifghtNeighbour)) {count++; }
                }
            }
            Console.WriteLine($"Number of elements bigger then their neighbours: {count}");            
        }

        
    }
}

