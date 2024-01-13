using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
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
        static void BigDataOperation(in int[] arr, ref int data)
        {
            data = 3;
            arr[0] = data;
        }
        static void GetAge(out string name, out byte age)
        {
            name = "Ugin";
            age = 58;
        }
        static void Echo(string saidword)
        {
            Console.WriteLine(saidword);
        }
        static void Echo1(string saidword, int deep)
        {
            var modif = saidword;
            if (modif.Length > 2)
            {
                //int a = modif.Length - 1;
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo1(modif, deep - 1);
            }
        }

        static Tuple<string, string, int, bool, int, string[], int, string[]> Corteg()
        {
            //(string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors) anketa;
            Console.WriteLine("Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            string surname = Console.ReadLine();
            int a;
            Ansver("Ваш возраст:", out a);
            int age = a;
            Console.WriteLine("Есть ли у вас питомцы? ");
            string ansv = Console.ReadLine();
            string[] namepets = ABS(ansv, out bool pet, out int quapet, out string[] nampets);
            
            Ansver("Сколько у вас любимых цветов?", out a);
            int quafavcolors = a;
            string[] favcolors = FavColors(quafavcolors);

            return Tuple.Create<string, string, int, bool, int, string[], int, string[]>(name, surname, age, pet, quapet, namepets, quafavcolors, favcolors);
        }
        static string[] ABS(string ansv, out bool pet, out int quapet, out string[] nampets)
        {
            //bool pet;
            switch (ansv)
            {
                case "Да":
                    pet = true;
                    int a;
                    Ansver("Сколько у вас питомцев?", out a);
                    quapet = a;
                    //string[] namepet = NamePets(quapet);
                    nampets = NamePets(quapet);
                    return nampets;

                    //break;
                case "да":
                    pet = true;
                    Ansver("Сколько у вас питомцев?", out a);
                    quapet = a;
                    nampets = NamePets(quapet);
                    return nampets;
                    //break;
                case "Нет":
                    pet = false;
                    nampets = new string[0];
                    quapet = 0;
                    return nampets;
                    //break;
                case "нет":
                    pet = false;
                    nampets = new string[0];
                    quapet = 0;
                    return nampets;
                    //break;
                default:
                    pet = false;
                    Console.WriteLine("К сожалению вы не ответили на вопрос.");
                    nampets = new string[0];
                    quapet = 0;
                    return nampets;
                    //break;
            }
        }




        /*
        static void Anketa()
        {
            (string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors) anketa;
            Console.WriteLine("Ваше имя:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            anketa.surname = Console.ReadLine();
            int a;
            Ansver("Ваш возраст:", out a);
            anketa.age = a;
            Console.WriteLine("Есть ли у вас питомцы? ");
            string pet = Console.ReadLine();
            switch (pet)
            {
                case "Да":
                    anketa.pet = true;
                    Ansver("Сколько у вас питомцев?", out a);
                    anketa.quapet = a;                    
                    NamePets(anketa.quapet);
                    break;
                case "да":
                    anketa.pet = true;
                    Ansver("Сколько у вас питомцев?", out a);
                    anketa.quapet = a;
                    NamePets(anketa.quapet);
                    break;
                case "Нет":
                    anketa.pet = false;                    
                    break;
                case "нет":
                    anketa.pet = false;
                    break;
                default:
                    Console.WriteLine("К сожалению вы не ответили на вопрос.");
                    break;
            }        
            Ansver("Сколько у вас любимых цветов?", out a);
            anketa.quafavcolors = a;
            FaveColors(anketa.quafavcolors);
            return;
        }*/
        static void Ansver(string num, out int a)
        {
            string num1;           
            do
            {
                Console.WriteLine(num);
                num1 = Console.ReadLine();

            }
            while (CheckNum(num1, out a));
        }
        static bool CheckNum(string num, out int intnum)
        {

            if (int.TryParse(num, out int number))
            {
                if (number > 0)
                {
                    intnum = number;
                    return false;
                }
            }
            {
                intnum = 0;
                return true;
            }            
        }


        static string[] FavColors(int quafavcolors)
        {
            var favecolors = new string[quafavcolors];

            for (int i = 0; i < favecolors.Length; i++)
            {
                Console.WriteLine("Введите название {0} цвета: ", i + 1);
                favecolors[i] = Console.ReadLine();
            }

            return favecolors;
        }
        static string[] NamePets(int quapet)
        {
            var namepets = new string[quapet];

            for (int i = 0; i < namepets.Length; i++)
            {
                Console.WriteLine("Введите имя {0} питомца: ", i + 1);
                namepets[i] = Console.ReadLine();
            }
            return namepets;
        }
        /*
        static void ShowAnketa(Anketa())
        {
            Console.WriteLine();
        }*/
        static void Main(string[] args)
        {
            
            //ShowAnketa();

        Console.ReadKey();
        }           
    }
}
