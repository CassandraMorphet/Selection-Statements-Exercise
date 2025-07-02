using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 11);
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Give me a number between 1 and 10");
                response = int.Parse(Console.ReadLine());


                if (response < favNumber)
                {
                    Console.WriteLine($"Too low! Try again.\nYour guess: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine("Too high! Try again.\nYour guess: {response}");
                }
                else
                {
                    Console.WriteLine($"You guessed it! \nThe number was {favNumber}.");
                }
            }



        }
    }
}
