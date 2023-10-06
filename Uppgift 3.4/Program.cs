using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Uppgift3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är din låt?");
            string låten = Console.ReadLine();
            int ochindex = låten.IndexOf(" ");
            string minut = låten[..ochindex];
            string sekund = låten[(ochindex + 1)..];
            int sekunder = int.Parse(sekund);
            int minuter = int.Parse(minut);
            switch (minuter)
            {
                case 2:

                    if (sekunder < 45 || sekunder > 60)
                    {
                        Console.WriteLine("Din låt får inte spelas");
                    }
                    break;

                case 3:
                    {
                        if (sekunder > 0 || sekunder > 60)
                        {
                            Console.WriteLine("Din låt får spelas");
                        }
                        break;
                    }
                case 4:
                    {
                        if (sekunder < 20 || sekunder > 60) ;
                        {
                            Console.WriteLine("Din låt får spelas");
                        }
                        break;


                    }
                default:
                    {
                        Console.WriteLine("Din låt får inte spelas");
                        break;
                    }
            }
        }
    }
}