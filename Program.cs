//using System.Data;
//using Internal;
//using System.Text.RegularExpressions;
using System;

namespace GuessingGame
{
    class Program
    {

        // Function to a random number

        static int newRandom(int limit) {
            int randomNumber = (new Random()).Next(1, limit);
            return randomNumber;
        }

        // Function to process the guess

        static void evaluateGuess(int randomNumber, int totalChances) {
            int chancesLeft = totalChances;

            for (int i = totalChances; i > 0; i--) {
                chancesLeft--;
                
                Console.Write("\nEnter an integer and press [ENTER]: ");

                try {
                    int userGuess = int.Parse(Console.ReadLine());

                    if (randomNumber == userGuess) {
                        Console.WriteLine("\nYou got it right");
                        break;
                    } 
                    
                    if (randomNumber != userGuess && chancesLeft != 0) {
                        Console.WriteLine("\nThat was wrong");
                        Console.Write("\nChances left: ");
                        Console.WriteLine(chancesLeft);
                    }
                } catch (Exception) {
                    Console.WriteLine ("\nOops! You must enter an integer");
                    break;
                }
            }

            if (chancesLeft == 0) {
                Console.WriteLine("\nGame over!");
            }
        }

        // The main function

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Guessing Game");

            // Define random number

            Console.WriteLine(
                "\nChoose a level"
                +"\n1. Easy"
                +"\n2. Medium"
                +"\n3. Hard"
            );

            int randomNumber = 0;
            int totalChances = 0;

            Console.Write("\nEnter a level here: ");
            string userLevel = Console.ReadLine();

            switch (userLevel) {
                case "1":
                case "Easy":
                case "easy":
                    Console.WriteLine("\nYou are playing the Easy level");
                    Console.WriteLine("You 6 chances");
                    randomNumber = newRandom(10);
                    totalChances = 6;
                    evaluateGuess(randomNumber, totalChances);
                    break;
                case "2":
                case "Medium":
                case "medium":
                    Console.WriteLine("\nYou are playing the Medium level");
                    Console.WriteLine("You 4 chances");
                    randomNumber = newRandom(20);
                    totalChances = 4;
                    evaluateGuess(randomNumber, totalChances);
                    break;
                case "3":
                case "Hard":
                case "hard":
                    Console.WriteLine("\nYou are playing the Hard level");
                    Console.WriteLine("You 3 chances");
                    randomNumber = newRandom(50);
                    totalChances = 3;
                    evaluateGuess(randomNumber, totalChances);
                    break;
                default:
                    Console.WriteLine("\nYou entered an invalid game level");
                    break;
            }
        }
    }
}
