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
            string[] namepet = new string[0];
            if (ansv == "Да")
            {                
                anketa.pet = true;
                int b;
                //string[] namepet;
                Ansver("Сколько у вас питомцев?", out b);
                anketa.quapet = b;
                namepet = NamePets(anketa.quapet);
            }
            else if (ansv == "да")
            {
                anketa.pet = true;
                int b;
                //string[] namepet;
                Ansver("Сколько у вас питомцев?", out b);
                anketa.quapet = b;
                namepet = NamePets(anketa.quapet);
            }
            else if (ansv == "Нет")
            {
                anketa.pet = false;
                //string[] namepet;
                namepet = new string[0];
                anketa.quapet = 0;
            }
            else if (ansv == "нет")
            {
                anketa.pet = false;
                //string[] namepet;
                namepet = new string[0];
                anketa.quapet = 0;
            }
            else
            {
                anketa.pet = false;
                Console.WriteLine("К сожалению вы не ответили на вопрос.");
                //string[] namepet;
                namepet = new string[0];
                anketa.quapet = 0;
            }
            anketa.namepets = namepet;
            //anketa.namepets = YesNoCheck(ansv, out int quapet1, out string[] nampets);
            
            Ansver("Сколько у вас любимых цветов?", out a);
            anketa.quafavcolors = a;
            anketa.favcolors = FavColors(a);
            var res = anketa;
            return res;
        }
        /*
        static string[] YesNoCheck(string ansv, out int quapet, out string[] nampets)
        {
            bool pet;
            if (ansv == "Да")
            {
                pet = true;
                int a;
                Ansver("Сколько у вас питомцев?", out a);
                quapet = a;
                nampets = NamePets(quapet);
            }
            else if (ansv == "да")
            {
                pet = true;
                int a;
                Ansver("Сколько у вас питомцев?", out a);
                quapet = a;
                nampets = NamePets(quapet);
            }
            else if (ansv == "Нет")
            {
                pet = false;
                nampets = new string[0];
                quapet = 0;
            }
            else if (ansv == "нет")
            {
                pet = false;
                nampets = new string[0];
                quapet = 0;
            }
            else
            {
                pet = false;
                Console.WriteLine("К сожалению вы не ответили на вопрос.");
                nampets = new string[0];
                quapet = 0;
            }
            
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
        
        static void ShowAnketa(string name, string surname, int age, bool pet, int quapet, string[] namepets, int quafavcolors, string[] favcolors)
        {            
            Console.WriteLine("Ваше имя: {0}",name);
            Console.WriteLine("Ваша фамилия: {0}", surname);
            Console.WriteLine("Ваш возраст: {0}", age);
            if (pet == true)
            {
                Console.WriteLine("У вас {0} питомцы.", quapet);
            }
            else
            {
                Console.WriteLine("У вас нет питомцев.");
            }            
            
            foreach (var namepet in namepets)
            {
                Console.WriteLine(namepet);
            }
            Console.WriteLine("У вас {0} любимых цвета. Это: ", quafavcolors);
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

            ShowAnketa(anketa1.name, anketa1.surname, anketa1.age, anketa1.pet, anketa1.quapet, anketa1.namepets, anketa1.quafavcolors, anketa1.favcolors);

            Console.ReadKey();
        }           
    }
}
