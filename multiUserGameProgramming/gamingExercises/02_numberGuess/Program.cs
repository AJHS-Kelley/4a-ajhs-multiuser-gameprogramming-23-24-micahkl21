// Micah Lecount, Program template, v0.1
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
            int
            int
            int
            int
            int
            string
            int
            int

            console.Writeline
            console.Writeline
            
            //Difficulty Selectoin
            Console.Writeline
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
            }
               

        }
    }
}
    

















































