string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0;
foreach(string value in values){
    decimal parsedValue;
    if (decimal.TryParse(value, out parsedValue)){
        total += parsedValue;
    }
    else {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");