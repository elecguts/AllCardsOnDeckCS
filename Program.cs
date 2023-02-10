using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates two lists of suits and ranks
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var ranks = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            //Creates an empty list to store the completed deck of cards
            var fullDeck = new List<string>();

            //Uses nested loops to combine and store the strings
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    fullDeck.Add($"{rank} of {suit}");
                }

            }

            //This code implements the Fisher-Yates shuffling algorithm
            for (var rightIndex = fullDeck.Count - 1; rightIndex > 0; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var randomNumber = randomNumberGenerator.Next(rightIndex);
                var leftIndex = randomNumber;
                var leftCard = fullDeck[leftIndex];
                var rightCard = fullDeck[rightIndex];
                fullDeck[leftIndex] = rightCard;
                fullDeck[rightIndex] = leftCard;
            }

            // These lists are the empty player hands for Players 1 and 2 for ADVENTURE mode
            var player1Hand = new List<string>();
            var player2Hand = new List<string>();

            //Draws 2 cards for each player and removes them from the deck, storing them in the player hands
            for (var cardDraw = 2; cardDraw > 0; cardDraw--)
            {
                player1Hand.Add(fullDeck[0]);
                fullDeck.RemoveAt(0);
                player2Hand.Add(fullDeck[0]);
                fullDeck.RemoveAt(0);
            }
            //Displays the contents of the player hands
            foreach (var card in player1Hand)
            {
                Console.WriteLine($"Player 1 was dealt {card}.");
            }
            foreach (var card in player2Hand)
            {
                Console.WriteLine($"Player 2 was dealt {card}.");
            }



        }
    }
}
