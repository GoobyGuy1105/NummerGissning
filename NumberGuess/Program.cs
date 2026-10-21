/*
Start

Generate a random number between 1 and 20
Set attempts to 0
Set correct to false

Print welcome message and instructions to player

While correct is false:

Ask the user to enter a guess 
Try to convert the input to a number
If the input is not a valid number
Ask the user to try again
Continue the next loop
Increase attempts by 1

If the guess is equal to the secret number:
Set correct to true
print("Congratulations you guessed it in X attempts")

Else if guess is lower than the secret number
print("Too Low")
Else
print("Too High"

Print(Thanks for Playing))

End
*/

int Attempts = 0;

bool Correct = false;

Random generator = new Random();

int SecretNumber = Random.Shared.Next(101);

Console.WriteLine($"Welcome! Can you guess what number im thinking of?");

    Console.WriteLine($"Go ahead! Im ready! Guess a number between 0 and 100!");

while (Correct == false)
{
    string YourGuess = Console.ReadLine();
    int Number;
    bool Success = int.TryParse(YourGuess, out Number);

    if (Success == false)
    {
        Console.WriteLine($"Bruh...");
        Attempts++;
    }
    else
    {
        if (Number == SecretNumber)
        {
            Correct = true;
            Console.WriteLine($"Congrats! Thats the number!");
            Console.WriteLine($"Total attempts: {Attempts}");
        }
        else if (Number > SecretNumber)
        {
            Console.WriteLine($"Nope! Thats too high! Try again!");
            Attempts++;
        }
        else
        {
            Console.WriteLine($"Nope! Thats too low! Try Again!");
            Attempts++;
        }
    }
}

Console.WriteLine($"Thanks for Playing! C:");
Console.WriteLine($"Press 'Enter' or click the 'X' at the top right of this window to exit.");

Console.ReadLine();
