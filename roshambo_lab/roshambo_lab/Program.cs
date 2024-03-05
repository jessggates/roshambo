using roshambo_lab;
using System.ComponentModel.Design;
using System.Text;



Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.WriteLine();

Console.Write("Enter your name: ");
string name = Console.ReadLine();
HumanPlayer humanPlayer = new HumanPlayer(name);

RockPlayer rockPlayer = new RockPlayer("The Chiefs");
RandomPlayer randomPlayer = new RandomPlayer("The 49ers");

bool validTeam = false;
string opponent = "";

while (validTeam == false)
{
    Console.WriteLine($"Would you like to play against {rockPlayer.Name} (enter 1) or {randomPlayer.Name} (enter 2)?");
    opponent = Console.ReadLine();
    validTeam = ValidTeam(opponent);
    if (validTeam == false)
    {
        Console.WriteLine("That is not a valid opponent! Choose 1 or 2.");
    }
}

bool playAgain = true;

while (playAgain)
{
    bool validChoice = false;
    while (validChoice == false)
    {
        Console.Write($"Rock, paper, or scissors? (R/P/S): ");
        string playerOption = Console.ReadLine().ToLower().Trim();
        validChoice = ValidChoice(playerOption);
        humanPlayer.UserChoice = playerOption;
        if (validChoice == false)
        {
            Console.WriteLine($"That is not a valid choice! Type R, P, or S for rock, paper, scissors.");
        }
    }

    humanPlayer.GenerateRoshambo();

    switch (opponent)
    {
        case "1":
            rockPlayer.GenerateRoshambo();
            Console.WriteLine($"{humanPlayer.Name}: {humanPlayer.RoshamboValue}");
            Console.WriteLine($"{rockPlayer.Name}: {rockPlayer.RoshamboValue}");
            Console.WriteLine($"{ReturnResult(humanPlayer.RoshamboValue, rockPlayer.RoshamboValue)}");
            break;
        case "2":
            randomPlayer.GenerateRoshambo();
            Console.WriteLine($"{humanPlayer.Name}: {humanPlayer.RoshamboValue}");
            Console.WriteLine($"{randomPlayer.Name}: {randomPlayer.RoshamboValue}");
            Console.WriteLine($"{ReturnResult(humanPlayer.RoshamboValue, randomPlayer.RoshamboValue)}");
            break;
    }
    bool validAnswer = false;
    while (validAnswer == false)
    {
        Console.WriteLine("Would you like to play again? (y/n)");
        string userAnswer = Console.ReadLine().ToLower().Trim();

        if (userAnswer == "y")
        {
            playAgain = true;
            validAnswer = true;
        }
        else if (userAnswer == "n")
        {
            playAgain = false;
            validAnswer = true;
        }
        else
        {
            Console.WriteLine("That is not a valid answer! Type 'y' for yes or 'n' for no.");
        }
    }
}
Console.WriteLine("Thanks for playing!");



static string ReturnResult(Roshambo firstValue, Roshambo secondValue)
{

    if (firstValue == secondValue)
        return "Draw";
    else if (
        (firstValue == Roshambo.Rock && secondValue == Roshambo.Scissors) ||
        (firstValue == Roshambo.Scissors && secondValue == Roshambo.Paper) ||
        (firstValue == Roshambo.Paper && secondValue == Roshambo.Rock)
        )
        return "Win!";
    else
        return "Lose";
}

static bool ValidTeam(string stringToCheck)
{
    if (stringToCheck == "1" || stringToCheck == "2")
        return true;
    else return false;
}

static bool ValidChoice(string stringToCheck)
{
    if (stringToCheck == "r" || stringToCheck == "p" || stringToCheck == "s")
        return true;
    else return false;
}

Console.ReadKey();


