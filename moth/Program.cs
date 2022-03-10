using System;

namespace moth_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aynizi daxil edin");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            { case 1:
                case 2:
                case 12: Console.WriteLine("qis ayidir"); break;
                    case 3:
                case 4:
                    case 5: Console.WriteLine("yaz ayidir"); break;
                case 6:
                    case 7:
                case 8: Console.WriteLine("yay ayidir"); break ;
                    case 9:
                        case 10:
                case 11: Console.WriteLine("payiz ayidir");
                    break;
                default:
                    Console.WriteLine("bele bir ay yoxdur");
                    break;
            }
        }
    }
}
