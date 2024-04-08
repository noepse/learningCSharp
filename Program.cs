for (int i = 1; i < 100; i++){
    string message = "";
    if (i%3 == 0){
        message+="Fizz";
    } if (i%5 == 0){
        message+="Buzz";
    }
    Console.WriteLine($"{i} - {message}");
}