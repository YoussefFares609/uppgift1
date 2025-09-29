

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
            if (double.TryParse(Console.ReadLine(), out betAmount) &&
            betAmount > 0 && betAmount <= balance)
                    break;
            Console.WriteLine("Wrong bet amount. Try again.");
        }

    }
    
    
    Console.Clear();
    int winningNumber = rand.Next(0, 37);
    string winningColor = (winningNumber == 0) ? "green" : (winningNumber % 2 == 0 ? "black" : "red");

    if (choice == "number")
    {
        int playerNumber;
        while (true)
        {
            Console.Write("Pick a number (0-36): ");
            if (int.TryParse(Console.ReadLine(), out playerNumber) &&
                playerNumber >= 0 && playerNumber <= 36)
                break;
            Console.WriteLine("Invalid number. Try again.");
        }

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
        string playerColor; 
        while (true)
        {
            Console.Write("Pick a color (red/black): ");
            playerColor = Console.ReadLine().Trim().ToLower();
            if (playerColor == "red" || playerColor == "black")
                break;
            else
            {
                Console.WriteLine("Invalid choice. Type 'red' or 'black'.");
            }
        }





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
        Console.WriteLine("You have no money left! Game over. BYE BYEEEE");
        break;
    }

    string again;
    while (true)
    {
        Console.Write("Do you want to play again? (yes/no): ");
        again = Console.ReadLine().Trim().ToLower();
        if (again == "yes" || again == "no")
            break;
        Console.WriteLine("Please type 'yes' or 'no'.");
    }
    if (again == "no")
    {
        Console.WriteLine("Thanks for playing! Final balance: $" + balance);
        break;
    }


}
