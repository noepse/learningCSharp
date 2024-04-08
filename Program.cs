using System;

string? readResult;
bool validEntry = false;

Console.WriteLine("Enter your role name (Administrator, Manager or User):");
do
{
    readResult = Console.ReadLine();
    if (readResult!= null)
    {
        if (readResult.ToLower().Equals("administrator") || readResult.ToLower().Equals("manager") || readResult.ToLower().Equals("user"))
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"You entered an invalid role ({readResult}). Please enter your role name (Administrator, Manager or User).");
        }
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");