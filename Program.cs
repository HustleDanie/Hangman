using System;

class Hangman
{
    static void Main(string[] args)
    {
        string secretWord = "computer"; // The secret word to guess
        int maxAttempts = 6; // The maximum number of attempts before game over

        // Create a char array to store the correctly guessed letters
        char[] guessedLetters = new char[secretWord.Length];
        for (int i = 0; i < guessedLetters.Length; i++)
        {
            guessedLetters[i] = '_'; // Initialize the array with underscores
        }

        int numAttempts = 0; // Keep track of the number of attempts

        while (numAttempts < maxAttempts)
        {
            // Print the current state of the game
            Console.WriteLine("Guessed letters: " + new string(guessedLetters));
            Console.WriteLine("Attempts remaining: " + (maxAttempts - numAttempts));

            // Get a letter from the user
            Console.Write("Guess a letter: ");
            char letter = Console.ReadLine().ToLower()[0]; // Convert to lowercase and take the first character

            // Check if the letter is in the secret word
            bool letterFound = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    guessedLetters[i] = letter; // Update the guessed letters array
                    letterFound = true;
                }
            }

            if (letterFound)
            {
                Console.WriteLine("Good guess!");
            }
            else
            {
                Console.WriteLine("Sorry, that letter is not in the word.");
                numAttempts++;
            }

            // Check if the word has been completely guessed
            if (new string(guessedLetters) == secretWord)
            {
                Console.WriteLine("Congratulations, you guessed the word!");
                return; // End the game
            }
        }

        // If we get here, the player has used up all their attempts
        Console.WriteLine("Game over. The word was: " + secretWord);
    }
}
