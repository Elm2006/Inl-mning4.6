using System;
namespace Inlämning_4.__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett meddelande");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hu många steg år höger ska meddelandet skrivas");
            int steg = int.Parse(Console.ReadLine());
            for (int i = 0; i < meddelande.Length; i++)
            {
               for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}