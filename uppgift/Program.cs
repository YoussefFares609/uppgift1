
using System.Reflection;

Random rand = new Random();

Console.Write("Enter a number (0-36): ");



while (true)
{

int winning = rand.Next(0, 37);
int guess = Convert.ToInt32(Console.ReadLine());
    if (guess < 0)
    {
        Console.WriteLine("I SAID 0-36!");
    }
    else if (guess > 36)
        Console.WriteLine("I SAID 0-36!");

if (guess == winning)
    {
        Console.WriteLine("You Won!");
    }
    else
    {
        Console.WriteLine("You Lost, try again");
    }
    
}



