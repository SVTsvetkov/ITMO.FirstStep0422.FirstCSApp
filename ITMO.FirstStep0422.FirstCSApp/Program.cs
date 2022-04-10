using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.FirstStep0422.FirstCSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "да";
            do
            {
                Console.WriteLine("Привет, ты профессиональный лыжник?");
                string result = Console.ReadLine();

                if (result == "да")
                {
                    Console.WriteLine("Похвально! Введи внешнюю температуру");
                    string temp = Console.ReadLine();
                    switch (temp)
                    {
                        case "-20":
                            Console.WriteLine("Используй тип мази VR25 для спортсменов");
                            break;
                        case "-10":
                            Console.WriteLine("Используй тип мази VR35 для спортсменов");
                            break;
                        case "0":
                            Console.WriteLine("Используй тип мази VR45 для спортсменов");
                            break;
                        default:
                            Console.WriteLine("Не существует такого типа мази для указанной температуры");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Всё впереди! А мы поможем! Введи внешнюю температуру");
                    string temp = Console.ReadLine();
                    switch (temp)
                    {
                        case "-20":
                            Console.WriteLine("Используй тип мази VR10 для любителей");
                            break;
                        case "-10":
                            Console.WriteLine("Используй тип мази VR20 для любителей");
                            break;
                        case "0":
                            Console.WriteLine("Используй тип мази VR40 для любителей");
                            break;
                        default:
                            Console.WriteLine("Не существует такого типа мази для указанной температуры");
                            break;
                    }
                }
                Console.WriteLine("Повторить выбор?");
                answer = Console.ReadLine();
            }
            while (answer == "да");
            Console.WriteLine("Новых рекордов на лыжне в любую погоду !");
        }
    }
}

