string? readResult;
bool validEntry = false;
int validNumber = 0;
Console.WriteLine("Enter a number containing between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (int.TryParse(readResult, out validNumber))
    {
        if (validNumber >= 5 && validNumber <=10)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"You entered an invalid number ({readResult}). Please enter a number between 5 and 10.");
        }
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");