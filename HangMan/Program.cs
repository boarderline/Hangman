using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLives = 6;
            string mysteryWord = "COMMON";
            int wordLength = mysteryWord.Length;
            List<string> lettersList = new List<string>();
       

            //initialize the list

            for (int n = 0; n < wordLength; n++)
            {
                lettersList.Add(" _ ");
            }

            for (int i = numberOfLives; i >= 1; i--)
            {
                Console.WriteLine("Let's play hangman!  What's your guess?  (lives left: " + i + ")");
                string input = Console.ReadLine().ToUpper();
                char guess = input[0];

                if (mysteryWord.Contains(guess.ToString()))
                {
                    for (int j = 0; j < wordLength; j++)
                    {
                        string letter = mysteryWord.Substring(j,1);
                        if (letter == guess.ToString())
                        {
                            lettersList[j] = letter;
                        }
                    }

                }
                foreach (string s in lettersList)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
                if (!lettersList.Contains(" _ "))
                {
                    Console.WriteLine("You win!");
                    break;
                }
            }
            if (lettersList.Contains(" _ "))
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadLine();
        }
    }
}
