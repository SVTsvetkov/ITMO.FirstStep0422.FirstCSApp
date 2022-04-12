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
            string answer = "y";
            do
            {
                Console.WriteLine("Hi, are you a professional skier? (y/n)");
                string result = Console.ReadLine();

                if (result == "y")
                {
                    Console.WriteLine("Great! Enter the outdoor temperature");
                    string outdoor = Console.ReadLine();

                    if (!int.TryParse(outdoor, out int temp))
                    {
                        Console.WriteLine("Not a number");
                    }
                    else
                    {
                        switch (temp)
                        {
                        case int n when (n >= -20 && n < -8):
                            Console.WriteLine("Use the VR25 type for athletes");
                            break;
                        case int n when (n >= -7 && n < -2):
                            Console.WriteLine("Use the VR35 type for athletes");
                            break;
                        case int n when (n >= -2 && n < 3):
                            Console.WriteLine("Use the VR45 type for athletes");
                            break;
                        default:
                            Console.WriteLine("There is no such type for the specified temperature");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Everything is ahead! And we will help you! Enter the outdoor temperature");
                    string outdoor = Console.ReadLine();

                    if (!int.TryParse(outdoor, out int temp))
                    {
                        Console.WriteLine("Not a number");
                    }
                    else
                    {
                        switch (temp)
                        {
                            case int n when (n >= -20 && n < -12):
                                Console.WriteLine("Use the VR10 type for amateur skiers");
                                break;
                            case int n when (n >= -11 && n < -5):
                                Console.WriteLine("Use the VR20 type for amateur skiers");
                                break;
                            case int n when (n >= -4 && n < 3):
                                Console.WriteLine("Use the VR30 type for amateur skiers");
                                break;
                            default:
                                Console.WriteLine("There is no such type for the specified temperature");
                                break;
                        }
                    }
                }
                Console.WriteLine("Repeat selection? (y/n)");
                answer = Console.ReadLine();
            }
            while (answer == "y");
            Console.WriteLine("Enjoy and have a new records on the ski track in any weather!");

        }
    }
}

