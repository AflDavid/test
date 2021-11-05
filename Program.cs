using System;

namespace TemaLNSB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Va placut orele de astazi?\n");
            Console.WriteLine("Alege da sau nu.");


            string ora = Console.ReadLine();
            if (ora == "da")
            {
                Console.WriteLine("A. Cioara\nFlorin Lazar\nO. Micula");
                Console.WriteLine("\nAlege profesorul care ti a placut cel mai mult!\n");
                string prof;
                prof = Console.ReadLine();
                if (prof == "O. Micula")
                    Console.WriteLine("Prof. Baze de date");
                else if (prof == "Florin Lazar")
                    Console.WriteLine("Prof. Bazele informaticii");
                else if (prof == "A. Cioara")
                    Console.WriteLine("Prof. Economia mondiala");


            }
            else if (ora == "nu")
            {
                Console.WriteLine("imi pare rau si multumim de feedback");
            }
           


            Console.WriteLine("Va placut orele de astazi?\n");
            Console.WriteLine("Alege da sau nu.");


            ora = Console.ReadLine();
            switch (ora)
            {
                case "da":
                    {
                        Console.WriteLine("A. Cioara\nFlorin Lazar\nO. Micula");
                        Console.WriteLine("\nAlege profesorul care ti a placut cel mai mult!\n");
                        string prof;
                        prof = Console.ReadLine();
                        if (prof == "O. Micula")
                            Console.WriteLine("Prof. Baze de date");
                        else if (prof == "Florin Lazar")
                            Console.WriteLine("Prof. Bazele informaticii");
                        else if (prof == "A. Cioara")
                            Console.WriteLine("Prof. Economia mondiala");
                    }
                    break;




                case "nu":
                    {
                        Console.WriteLine("imi pare rau si multumim de feedback");
                    }
                    break;
                default: Console.WriteLine("greseala in scriere"); break;


            }
        }
    }
}