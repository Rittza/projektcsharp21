using System;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Välkommen till 21:an!");

                int playerScore = PlayGame();

                Console.WriteLine("Ditt poäng: " + playerScore);

                if (playerScore > 21)
                {
                    Console.WriteLine("Du förlorade!");
                }
                else
                {
                    int computerScore = PlayComputer();
                    Console.WriteLine("Datorns poäng: " + computerScore);

                    if (computerScore > 21 || playerScore > computerScore)
                    {
                        Console.WriteLine("Grattis, du vann!");
                    }
                    else
                    {
                        Console.WriteLine("Datorn vann!");
                    }
                }

                Console.WriteLine("Vill du spela igen? (ja/nej)");
                string playAgainInput = Console.ReadLine();

                playAgain = (playAgainInput.ToLower() == "ja");
                Console.Clear();
            }
        }

        static int PlayGame()
        {
            int score = 0;
            string choice;

            do
            {
                int card = GetRandomCard();
                score += card;

                Console.WriteLine("Ditt kort: " + card);
                Console.WriteLine("Din totalpoäng: " + score);

                if (score >= 21)
                {
                    break;
                }

                Console.WriteLine("Vill du dra ett till kort? (ja/nej)");
                choice = Console.ReadLine();

                Console.Clear();
            } while (choice.ToLower() == "ja");

            return score;
        }

        static int PlayComputer()
        {
            int score = 0;

            while (score < 17)
            {
                int card = GetRandomCard();
                score += card;
            }

            return score;
        }

        static int GetRandomCard()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }
    }
}