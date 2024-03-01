using roshambo_lab;



Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.WriteLine();

Console.Write("Enter your name: ");
string name = Console.ReadLine();
HumanPlayer humanPlayer = new HumanPlayer(name);

RockPlayer rockPlayer = new RockPlayer("The Chiefs");
RandomPlayer randomPlayer = new RandomPlayer("The 49ers");

Console.Write($"Would you like to play against {rockPlayer.Name} (enter 1) or {randomPlayer.Name} (enter 2)?");
Console.WriteLine();
string opponent = (Console.ReadLine());
//add validation where the right team needs to be entered
bool playAgain = true;
while (playAgain)
{
    Console.Write($"Rock, paper, or scissors? (R/P/S): ");
    string playerOption = Console.ReadLine().ToLower().Trim();
    // add validation where a valid entry is required

    humanPlayer.UserChoice = playerOption;

    humanPlayer.GenerateRoshambo();

    switch (opponent)
    {
        case "1":
            rockPlayer.GenerateRoshambo();
            Console.WriteLine($"{humanPlayer.Name}: {humanPlayer.RoshamboValue}");
            Console.WriteLine($"{rockPlayer.Name}: {rockPlayer.RoshamboValue}");
            break;
        case "2":
            randomPlayer.GenerateRoshambo();
            Console.WriteLine($"{humanPlayer.Name}: {humanPlayer.RoshamboValue}");
            Console.WriteLine($"{randomPlayer.Name}: {randomPlayer.RoshamboValue}");
            break;
        default:
            Console.WriteLine($"That is not a valid choice. Please enter 1 ({rockPlayer.Name}) or 2 ({randomPlayer.Name}).");
            break;
    }
    Console.WriteLine("Would you like to play again? (y/n)");
    playAgain = Console.ReadLine() == "y";
}

Console.ReadKey();


