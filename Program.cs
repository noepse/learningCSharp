string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

string reversedString = "";

foreach(string word in words){
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    string reversedWord = String.Join("", chars);
    reversedString += reversedWord + " ";
}

string trimmedReversedString = reversedString.TrimEnd();
Console.WriteLine($"{trimmedReversedString}");