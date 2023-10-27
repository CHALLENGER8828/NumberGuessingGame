Random random = new Random();
bool playAgain = true; 
int number;
int guess;
int guesses;
String response; 


while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = ""; 
    number = random.Next(1, 101);


    while (guess != number)
    {
        Console.WriteLine("Guess a number between 1-100");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess:" + guess);
  
    if (guess > number)
        {
            Console.WriteLine(guess + " was too high");
        }
    else if (guess < number)
        {
            Console.WriteLine( guess +  " was too low");
        }
    guesses++;  
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("YOU WIN!");
    Console.WriteLine("Guesses: "  + guesses);

   
}
