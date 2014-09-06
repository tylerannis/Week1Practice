using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GetWord();
            Console.ReadKey();
        }
        static void GetWord()
        {
            //Ask for the players name
            Console.WriteLine("What is your name");
            //First the player inputs their name
            string name = Console.ReadLine();
            //Then I greet them using their name and explain how the game works
            Console.WriteLine("Welcome to HangMan, " + name + "\nA word will be chosen at random and you must try to guess the letters of the word or the whole word itself. Once you correctly guess all of the letters or the whole word you win. If you guess wrong 6 times you will lose.");
           
            
            //set a variable for the random word
            string word = string.Empty;
            //set a readline for the players guess
            string playerGuess = string.Empty;
            //set a limit for howmany wrong guesses they can have
            int numGuesses = 6;
            //set variable for letters guessed
            string lettersguessed = string.Empty;


            //make a wordbank for the words they can guess about
            List<string> wordBank = new List<string> { "Justice", "Batman", "Queen", "Flash", "Multiverse", "Joker", "Metropolis", "Danger" };
            //make a random number geny
            Random ran = new Random();
            //get random index number
            int index =  ran.Next(0, wordBank.Count);
            //get a word from wordBank using a random index number
            word = wordBank[index].ToLower();
            //make a boolean value to end the game
            bool won = false;
            

            //make a while loop to keep track of the game flow
            while (!won || numGuesses > 0)
            {
                //call masked word function
                string underscores = MaskWord(word, lettersguessed);
                //print your masked function
                Console.WriteLine(underscores);
                Console.WriteLine();
                //print letters guessed and number of guesses left
                Console.WriteLine(lettersguessed  + "\nYou have " + numGuesses + " guesses left");
                //ask for a letter
                Console.WriteLine("Make a guess.");
                playerGuess = Console.ReadLine().ToLower();
                //ask if the guess is 1 char
                if (playerGuess.Length == 1)
                {


                    //ask if the guess is right
                    if (word.Contains(playerGuess))
                    {
                        //it is so add the guess to lettersguessed
                        lettersguessed += playerGuess;
                        Console.WriteLine("Correct, good job" + name);
                    }

                    else
                    {
                        //if they are wrong still add the guess to letters list but also subtract a life from numguessess
                        lettersguessed += playerGuess;
                        numGuesses -= 1;
                        Console.WriteLine("WRONG, try agian" + name);
                    }
                }
                else
                {
                    //if they guess the whole word
                    if (word == playerGuess)
                    {
                        Console.WriteLine("Great job, " + name + " you WON");
                    }
                    //if they guess a wrong word
                    else if (word != playerGuess)
                    {
                        numGuesses--;
                        Console.WriteLine("Sorry guess again");
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time");
                    }
                
               
                }
            }
        }
        static string MaskWord(string word, string letterguessed)
    {
        string hide = string.Empty;
        //set a limit for howmany wrong guesses they can have
        int numGuesses = 6;

        for (int i = 0; i < word.Length; i++)
        {
            //saying that it's a letter and the letter is where [i] is
            char letter = word[i];

            if (letterguessed.Contains(letter.ToString()))
            {
                hide += letter + " ";
            }
            else
            {
                hide = hide + "_ ";
                numGuesses--;
            }
        }
        return hide;

    }
    }
}
