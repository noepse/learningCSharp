﻿Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay(){
    string? readline = Console.ReadLine();
    if (readline.ToLower() == "y"){
        return true;
    }
    else return false;
}

string WinOrLose(int target, int roll){
    if (roll > target){
        return "You win!";
    } else return "You lose!";
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        play = ShouldPlay();
    }
}