using System;
using System.Collections.Generic;
using System.Linq;

namespace RominaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var rounds = 100;

            var player1Choice = Choices.Rock;
            var rng = new Random();
            var results = new List<int>();

            for (int i = 0; i < rounds; i++)
            {
                // we make a random choice for the second player
                var player2Choice = (Choices)rng.Next(1, 4);

                // we get the result of the game
                var result = CheckWinner(player1Choice, player2Choice);

                // we add the result in a list to aggregate them later.
                results.Add(result);
            }

            var draws = results.Count(c => c == 0);
            var p1wins = results.Count(c => c == 1);
            var p2wins = results.Count(c => c == 2);

            Console.WriteLine($"The results for {rounds} rounds were as following:");

            Console.WriteLine($"There were {draws} draws.");
            Console.WriteLine($"There were {p1wins} wins for player 1.");
            Console.WriteLine($"There were {p2wins} wins for player 2.");
        }

        /// <summary>
        /// Returns 0 if draw, 1 if player 1 wins, 2 if player 2 wins.
        /// </summary>
        static int CheckWinner(Choices player1Choice, Choices player2Choice)
        {
            if (player1Choice == Choices.Rock)
            {
                switch (player2Choice)
                {
                    case Choices.Rock:
                        // if player 2 has rocks, it's a draw
                        return 0;
                    case Choices.Scissor:
                        // if player 2 has scissor, player 1 wins
                        return 1;
                    case Choices.Paper:
                        // if player 2 has paper, they win
                        return 2;
                }
            }

            if (player1Choice == Choices.Paper)
            {
                switch (player2Choice)
                {
                    case Choices.Rock:
                        // if player 2 has rocks, player 1 wins
                        return 1;
                    case Choices.Scissor:
                        // if player 2 has scissor, player 2 wins
                        return 2;
                    case Choices.Paper:
                        // if player 2 has paper, it's a draw
                        return 0;
                }
            }

            if (player1Choice == Choices.Scissor)
            {
                switch (player2Choice)
                {
                    case Choices.Rock:
                        // if player 2 has rocks, player 2 wins
                        return 2;
                    case Choices.Scissor:
                        // if player 2 has scissor, it's a draw
                        return 0;
                    case Choices.Paper:
                        // if player 2 has paper, player 1 wins
                        return 1;
                }
            }

            // it will never reach here
            return -1;
        }
    }
}