using System;

namespace moth_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aynizi daxil edin");
            string month = Console.ReadLine();
            switch (month)
            { case "Yanvar":
                case "Fevral":
                case "Dekabr": Console.WriteLine("qis ayidir"); break;
                    case "Mart":
                case "Aprel":
                    case "May": Console.WriteLine("yaz ayidir"); break;
                case "Iyun":
                    case "Iyul":
                case "Avqust": Console.WriteLine("yay ayidir"); break ;
                    case "sentyabr":
                        case "Oktaybr":
                case "Noyabr": Console.WriteLine("payiz ayidir");
                    break;
                default:
                    Console.WriteLine("bele bir ay yoxdur");
                    break;
            }
        }
    }
}
