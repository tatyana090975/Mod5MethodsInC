using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5MethodsInC
{
    internal class Program
    {
        static string ShowColor(string username, int age)
        {
            Console.WriteLine($"{username}, {age} лет \nнапишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
               
            }
            return color;
        }

        static void ShowColors(string username, params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");


            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] result)
        {
            int temp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }                    
                }
            }
            foreach (var item in result)
            {
                Console.Write(item);
            }
            return result;
        }
        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
            }
        }
        static void PrintArray(params int[] array)
        {
            foreach (var arr in array)
            {
                Console.Write($"{arr} ");
            }
        }
        static void ShowArray(int[] array, bool IsSort = false)
        {
            if (IsSort) SortArray(array);

            foreach (var arr in array)
            {
                Console.Write($"{arr} ");
            }
        }
        static string GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            return name;    
        }
        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int Age = 27;
            Console.WriteLine(Age);
            ChangeAge(ref Age);
            Console.WriteLine(Age);
            var Name = "Ugin";
            Console.WriteLine(Name);
            Name = GetName(Name);
            Console.WriteLine(Name);
            /*
            Console.WriteLine("Введите размер массива: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                int[] arr = GetArrayFromConsole(num);
                ShowArray(arr);
            }
            catch
            {
                int[] arr = GetArrayFromConsole();
                PrintArray(arr);
            }*/

            Console.ReadKey();
        }
    }
}
