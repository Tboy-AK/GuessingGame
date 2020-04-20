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

            // Setup shopping list

            /*List<string> shoppingList = new List<string> ();
            shoppingList.Add ("tomatoes");
            shoppingList.Add ("");
            shoppingList.Add ("yam");
            shoppingList.Add ("water");
            shoppingList.Add ("rice");
            shoppingList.Add ("");
            shoppingList.Add ("garri");
            shoppingList.Add ("beans");
            shoppingList.Add ("");
            shoppingList.Add ("pepper");

            // An array of available markets

            string[] markets = new string[8];
            markets[0] = "None";
            markets[1] = "Oshodi";
            markets[2] = "Agege";
            markets[3] = "Ikeja";
            markets[4] = "Eko";
            markets[5] = "Egbeda";
            markets[6] = "Ojota";
            markets[7] = "Marina";

            // Programme start

            Console.WriteLine ("Welcome to general arithmetic calculator\n");

            Console.WriteLine ("What market will you like to go today?");
            Console.WriteLine ("0. None");
            Console.WriteLine ("1. Oshodi");
            Console.WriteLine ("2. Agege");
            Console.WriteLine ("3. Ikeja");
            Console.WriteLine ("4. Eko");
            Console.WriteLine ("5. Egbeda");
            Console.WriteLine ("6. Ojota");
            Console.WriteLine ("7. Marina");
            Console.Write ("\nType in the corresponding number: ");

            // Check against array being out of range
            // Check against string-to-number conversion
            // Process users's requests and provide responses

            try {
                choiceIndex = int.Parse (Console.ReadLine ());

                choice = markets[choiceIndex];

                if (choice == "None") {
                    result = "No shopping today. Have a relaxing day at home. Enjoy!";
                } else if ((choice == "Eko" || choice == "Marina") && shoppingList[2] == "yam" && shoppingList[9] == "pepper") {
                    result = "You will have to wait for 4hrs to avoid traffic congestion. Please be patient!";
                } else if ((choice == "Ojota") && shoppingList[6] != "") {
                    result = "You will have to stop at Mama Lasisi's for garri before heading to the big market. You're welcome!";
                } else {
                    result = "You will have a stress-free day at the market today. Congrats!";
                }

                Console.WriteLine ();

                Console.WriteLine (result);

            } catch (Exception) {
                Console.WriteLine ("\nOops! Choose within the given number range of options.");
                Console.Write ("That is: 0 to ");
                Console.WriteLine (markets.Count ());
            }*/
        }
    }
}
