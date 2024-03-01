using roshambo_lab;



Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.WriteLine();

Console.Write("Enter your name: ");
string name = Console.ReadLine();
HumanPlayer player = new HumanPlayer(name);

RockPlayer rockPlayer  = new RockPlayer("The Chiefs");
RandomPlayer randomPlayer = new RandomPlayer("The 49ers");

Console.Write($"Would you like to play against {rockPlayer.Name} or {randomPlayer.Name}");
Console.WriteLine();
string opponent = Console.ReadLine();


Console.Write($"Rock, paper, or scissors? (R/P/S");
string playerOption = Console.ReadLine().ToLower().Trim();
player.UserChoice = playerOption;

//switch on r/p/s and give value

/* this is wrong, fix
switch(opponent)
{
    case rockPlayer:
        RockPlayer.GenerateRoshambo();
        break;

}
*/



