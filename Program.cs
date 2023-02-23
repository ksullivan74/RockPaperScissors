using System;
using System.Collections.Generic;
/*
Program a rock paper scissors game as a console application. 
The user should play against the computer which makes random selections on each turn.

The game should end when either the user or the computer gets to 3 points.
At that point the user should be shown a message saying either "YOU WIN" or "YOU LOSE" 
and the program should exit.
*/


/*
//Rock
Console.WriteLine($@"""
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
""");
//Paper
Console.WriteLine($@"""
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
""");
//Scissors
Console.WriteLine($@"""
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
""");
*/

class Program
{
    static void Main(string[] args)
    {


        // Array of options for the computer to choose from
        string[] options =
        { "rock", "paper", "scissors" };

        // Random number generator for the computer's choice
        Random rand = new Random();

        // Scores for the user and the computer
        int userScore = 0;
        int computerScore = 0;

        Console.WriteLine("+------------------------+----------------------------+");
        Console.WriteLine($"|  Player: {userScore}  |  Computer: {computerScore} |");
        Console.WriteLine("+------------------------+----------------------------+");

        while (userScore < 3 && computerScore < 3)
        {
            // Prompt user for their choice
            Console.Write("What would you like to throw? 1.)rock, 2.)paper, or 3.)scissors: ");
            string userChoice = Console.ReadLine().ToLower();

            // Make sure user input is valid
            if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
            {
                Console.WriteLine("Invalid input. Please choose rock, paper, or scissors.");
                continue; // Restart the loop
            }

            // Computer chooses a random option
            int computerIndex = rand.Next(options.Length);
            string computerChoice = options[computerIndex];

            // Print the choices
            Console.WriteLine($"You chose {userChoice}, computer chose {computerChoice}.");

            // Determine the winner
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors")
                  || (userChoice == "paper" && computerChoice == "rock")
                  || (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win this round!");
                userScore++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computerScore++;
            }

            // Print the scores
            Console.WriteLine($"Score: You {userScore}, Computer {computerScore}");

            // Check if either player has reached 3 points
            if (userScore == 3)
            {
                Console.WriteLine("YOU WIN!");
            }
            else if (computerScore == 3)
            {
                Console.WriteLine("YOU LOSE!");
            }
        }
    }
}
