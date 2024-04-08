Random random = new Random();

int number = random.Next(0, 2);

Console.Write($"You flipped a {(number == 0 ? "heads" : "tails")}");