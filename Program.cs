using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5MethodsInC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя пользователя: ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите пять любимых блюд: ");
            string[] Dishes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Dishes[i] = Console.ReadLine();
            }
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Dishes[i]);
            }*/
            Console.ReadKey();
        }
    }
}
