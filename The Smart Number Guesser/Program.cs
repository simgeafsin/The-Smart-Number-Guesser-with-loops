using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Smart_Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int targetNumber = rnd.Next(1, 101);

            int guessnumber = 0;
            int count = 0;

          
            while (guessnumber != targetNumber)
            {
                Console.Write("Enter your guess: ");
                guessnumber = int.Parse(Console.ReadLine()); 
                count++;

                if (guessnumber < targetNumber)
                {
                    Console.WriteLine("Go HIGHER! ⬆️");
                }
                else if (guessnumber > targetNumber)
                {
                    Console.WriteLine("Go LOWER! ⬇️");
                }
                else
                {
                    Console.WriteLine("Congratulations! 🎉");
                    Console.WriteLine("You found it in " + count + " attempts.");
                }









            Console.Read();
        }
    }
}
