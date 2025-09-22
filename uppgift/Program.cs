

Random rand = new Random();
double balance = 100; 

Console.WriteLine("Welcome to Roulette!");
Console.WriteLine("You start with $" + balance);

while (true)
{
    Console.WriteLine("Current balance: $" + balance);

    
    Console.Write("Do you want to bet on 'number' or 'color'? ");
    string choice;
    while (true)
    {
        choice = Console.ReadLine().Trim().ToLower();
        if (choice == "number" || choice == "color")
        {
           break;
        } 
        else 
        { 
            Console.WriteLine("Wrong choice. Please type 'number' or 'color'.");
            
        }
    }

 
    double betAmount;

    while (true) 
    {

        {
            Console.Write("Enter your bet amount: $");
            betAmount = Convert.ToDouble(Console.ReadLine());
            if (betAmount > 0 && betAmount <= balance)
                break;
            Console.WriteLine("Wrong bet amount. Try again.");
        }

    }
    
    
    Console.Clear();
    int winningNumber = rand.Next(0, 37);
    string winningColor = (winningNumber == 0) ? "green" : (winningNumber % 2 == 0 ? "black" : "red");

    if (choice == "number")
    {
        Console.Write("Pick a number (0-36): ");
        int playerNumber = Convert.ToInt32(Console.ReadLine());

        if (playerNumber == winningNumber)
        {
            double winnings = betAmount * 35;
            balance += winnings;
            Console.WriteLine("You win! Number was " + winningNumber + " (" + winningColor + ")");
            Console.WriteLine("You won $" + winnings + "! Current balance: $" + balance);
        }
        else
        {
            balance -= betAmount;
            Console.WriteLine("You lose! Number was " + winningNumber + " (" + winningColor + ")");
            Console.WriteLine("Lost $" + betAmount + ". Current balance: $" + balance);
        }
    }
    else if (choice == "color")
    {
        Console.Write("Pick a color (red/black): ");
        string playerColor = Console.ReadLine().Trim().ToLower();

        if (playerColor == winningColor)
        {
            double winnings = betAmount * 2; 
            balance += winnings;
            Console.WriteLine("You win! Number was " + winningNumber + " (" + winningColor + ")");
            Console.WriteLine("You won $" + winnings + "! Current balance: $" + balance);
        }
        else
        {
            balance -= betAmount;
            Console.WriteLine("You lose! Number was " + winningNumber + " (" + winningColor + ")");
            Console.WriteLine("Lost $" + betAmount + ". Current balance: $" + balance);
        }
    }
    else
    {
        Console.WriteLine("wrong choice. Type 'number' or 'color'.");
        
    }

  
    if (balance <= 0)
    {
        Console.WriteLine("You have no money left! Game over.");
        
    }

    Console.Write("Do you want to play again? (yes/no): ");
    string again = Console.ReadLine().Trim().ToLower();
    if (again == "no")
    {
        Console.WriteLine("Thanks for playing! Final balance: $" + balance);
        break;
    }
}