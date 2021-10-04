/// Chapter No. 13		Lab No. 1
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  October 3, 2021
///
/// Problem Statement: Create a guessing game. Every guess, the game should
///                    inform if the guess should go higher or lower. When
///                    the number is guessed, display the number of guesses.
/// 
/// Overall Plan:
/// 1)  Create an int called number and set it to a random number between 1
///     and 100.
/// 2)  Create two ints, guesses and guess, and set both to zero.
/// 3)  Create a while loop that will break when guess is the same as number.
/// 4)  Prompt the user to guess a number. Read the console and store the
///     input in guess.
/// 5)  Increment guesses by 1.
/// 6)  If guess is greater than number, tell the user to guess lower.
/// 7)  Else if guess is lower, tell the user to guess higher.
/// 8)  Outside the loop, tell the user they guessed correctly, then tell them
///     how many guesses they took.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 0 and 100!");

            Random rand = new Random();
            int number = rand.Next(1, 100);
            int guess = 0, guesses = 0;
            while (guess != number)
            {
                Console.WriteLine("Guess a number: ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                if (guess > number)
                {
                    Console.WriteLine("Try a lower guess.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Try a higher guess.");
                }
            }

            Console.WriteLine("You guessed correctly!");
            Console.WriteLine("It took you " + guesses + " guesses to get the number!");
            Console.Read();
        }
    }
}
