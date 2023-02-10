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
            Console.WriteLine($"The deck is shuffled and the first two cards off the top of the deck are {fullDeck[0]} and {fullDeck[1]}.");
        }
    }
}
