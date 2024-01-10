using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5MethodsInC
{
    internal class Program
    {
        static string ShowColor(string color)
        {
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //var color = Console.ReadLine();

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

        static void Main(string[] args)
        {
            string[] favcolors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                favcolors[i] = Console.ReadLine();
                ShowColor(favcolors[i]);
            }
            Console.WriteLine("Ваши любимые цвета:");
            for (int k = 0; k < favcolors.Length; k++)
            {
                Console.WriteLine(favcolors[k]);
            }
            
            Console.ReadKey();
        }
    }
}
