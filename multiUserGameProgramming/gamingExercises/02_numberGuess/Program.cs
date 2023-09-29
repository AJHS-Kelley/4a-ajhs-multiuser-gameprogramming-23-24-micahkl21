// Micah Lecount, Program template, v0.3
/*
Generate secret number from a defined range of numbers (i.e. 0-10-50, 0-100)
Print game instructions including range and num. of guess allowed.
    MATCH == first player to score 3 points.
    Round == guessing a specific number, until correct or no more attempts 
Ask the player what difficulty they want to play on
Ask the player what their guess is.
Determine if guess is correct or not.
    If guess is correct {
        Tell them they have guessed correctly
        Award the player a point
    } else {
        Tell them they are wrong.
        Tell player if guess is toohigh or too low.
        Check to see of they have guesses remaining {
            If guess remain: {
                aloow player to guess again.
            } else {
                CPU wins the round.
            }
        }
*/
using System;

namespace numberGues
{
    
    class numberGuess
    {

        static void Main(string[] args)
        {
            int secretNumber = -1; // Number of guesses player is ALLOWED
            int numGuesses = 0; // Number of guesses TAKEN
            int numAttempts = 0;
            int playerGuess = 0;
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = ""
            int rangeMin = -1;
            int rangeMax = -1;

            console.Writeline("Welcome to the Muber Guess Game!\nYou will select a difficulty next.\n");
            console.Writeline("Easy Mode: Range 0 - 10 with 4 guesses.\nNormal Mode: Range 0 - 25 with 4 guesses.\nHard Mode: range is 0 - 50 with 3 guesses.\n");
            
            //Difficulty Selectoin
            Console.Writeline("Please type Easy, Normal, or Hard and press ENTER.")
            difficulty = Console.Readline();
            // Console.Readline()will save STRING by default
            Console.Writeline("You have selected " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangMax = 10;
                numGuess = 4
            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangemax = 25;
                numGuess = 4;
            } else if (difficulty == "Hardl") {
                rangeMin = 0;
                rangemax = 50;
                numGuess = 3;
            } else {
                // Code to run if no difficulty is selected.
                Console.Writeline("No difficulty selected correctly,defaulting to Normal.\n");
                rangeMin = 0;
                rangemax = 25;
                numGuess = 4;
            }
            Console.Writeline("Minimum: " + rangeMin);
            Console.Writeline("Maximum: " + rangeMax);
            Console.Writeline("Num. Guesses: " + numGuesses);

            // START THE MATCH!
            while (playerScore != 3 && cpuScore != 3) {
                //
                //
                random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                Console.Writeline("Player Score: " + playerScore + "\n"")
                Conmsole.Writeline("CPU Score: " + cpuScore + "\n")")
                // START EACH ROUND
                for (int i = 0; i < numGuesses ; i++) {
                    // Code to guess
                    Console.Writeline("You have used " + numAttempts + "this round.\n");
                    Console.Writeline("You must guess between " + rangeMin + "and " + rangeMax + ".\n");
                    playerGuess = System.Convert.ToInt32(Conmsole.Readline())
                    if (playerGuess == secretNumber) {
                        //
                        playerScore++;
                        break;
                    } else {
                        if (playerGuess > secretNumber) {
                            Conmsole.Writeline("Your guess is too high!\n");
                        } else {
                            Conmsole.Writeline("Your guess is too low!\n");
                        }
                    }
                    numAttempts++;
                }
                if (playerGuess != secretNumber) {
                    cpuScore++;
                    //
                }
            }
            if (playerScore >= 3) {
                Conmsole.Writeline("You have won the game!\n");
            } else {
                Conmsole.Writeline("You have lost the game!\n");
            }
        }
    }
}
    

















































