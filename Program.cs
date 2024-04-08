string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

foreach(string str in myStrings){
    string remainingStr = str;

    if (str.Contains(".")){
    periodLocation = str.IndexOf(".");
    } else periodLocation = -1;

    string subStr;

    while (periodLocation != -1) {
        subStr = remainingStr.Remove(periodLocation);
        remainingStr = remainingStr.Substring(periodLocation + 1).TrimStart();
        periodLocation = remainingStr.IndexOf(".");
        Console.WriteLine(subStr);
    } 
    Console.WriteLine(remainingStr);
}
