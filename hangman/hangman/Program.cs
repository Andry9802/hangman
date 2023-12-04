using System;
using System.Text.RegularExpressions;

namespace hangman
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            // List of words that the player has to guess
            string[] words = { "csharp", "visualstudio", "language", "array", "variable", "parsing", "constant" };

            // To verify the player's input is within 'a' and 'z'
            var validCharacters = new Regex("^[a-z]$");

            // Find a random number
            int myRandomNumber = new Random().Next(0, words.Length - 1);

            // Pick a random word from the array
            string wordToGuess = words[myRandomNumber];

            // Number of lives
            int lives = 3;

            // List of letters submitted by the player
            List<string> letters = new();

            // As long as the player has lives left, the game continues
            while (lives != 0)
            {

            }

        }
    }
}