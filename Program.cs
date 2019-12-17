using System;

namespace RominaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var rounds = 100;

            var player1Choice = Choices.Rock;
            var rng = new Random();

            for (int i = 0; i < rounds; i++)
            {
                var player2Choice = (Choices)rng.Next(1, 4);


            }

            Console.WriteLine("Hello World!");
        }
    }
}
