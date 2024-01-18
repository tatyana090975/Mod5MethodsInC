using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mod5MethodsInC
{
    internal class Program
    {    
        static (string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors) CreateAnketa((string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors) anketa)
        {            
            Console.WriteLine("Ваше имя:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            anketa.surname = Console.ReadLine();
            int a;
            Ansver("Ваш возраст:", out a);
            anketa.age = a;
            Console.WriteLine("Есть ли у вас питомцы? ");
            string ansv = Console.ReadLine();
            anketa.namepets = YesNoCheck(ansv, out bool pet1, out int quapet1, out string[] nampets);
            
            Ansver("Сколько у вас любимых цветов?", out a);
            anketa.quafavcolors = a;
            anketa.favcolors = FavColors(a);
            var res = anketa;
            return res;
        }
        static string[] YesNoCheck(string ansv, out bool pet, out int quapet, out string[] nampets)
        {            
            switch (ansv)
            {
                case "Да":
                    pet = true;
                    int a;
                    Ansver("Сколько у вас питомцев?", out a);
                    quapet = a;                    
                    nampets = NamePets(quapet);
                    return nampets;
                case "да":
                    pet = true;
                    Ansver("Сколько у вас питомцев?", out a);
                    quapet = a;
                    nampets = NamePets(quapet);
                    return nampets;                    
                case "Нет":
                    pet = false;
                    nampets = new string[0];
                    quapet = 0;
                    return nampets;                    
                case "нет":
                    pet = false;
                    nampets = new string[0];
                    quapet = 0;
                    return nampets;                    
                default:
                    pet = false;
                    Console.WriteLine("К сожалению вы не ответили на вопрос.");
                    nampets = new string[0];
                    quapet = 0;
                    return nampets;                    
            }
        }
       
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
        
        static void ShowAnketa(string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors)
        {            
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(age);
            Console.WriteLine(pet);
            Console.WriteLine(quapet);
            foreach (var namepet in namepets)
            {
                Console.WriteLine(namepet);
            }
            Console.WriteLine(quafavcolors);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
                
        }
        static void Main(string[] args)
        {
            (string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors) anketa = 
                ("", "", 0, false, 0, new string[0], 0, new string[0]);
            
            
            
            var anketa1 = CreateAnketa(anketa);

            ShowAnketa(anketa);

            Console.ReadKey();
        }           
    }
}
