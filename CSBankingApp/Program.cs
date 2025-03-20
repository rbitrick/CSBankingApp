


static void Get_Balance(float balance)
{
    Console.WriteLine("****************");
    Console.WriteLine("Your balance is " + balance.ToString("c2"));
    Console.WriteLine("****************");

}

static float Deposit()
{
    bool validoption = false;
    while (validoption != true)
    {

        Console.WriteLine("****************");
        Console.WriteLine("Please enter an amount to deposit");
        Console.WriteLine("****************");
        float amount = float.Parse(Console.ReadLine());

        if (amount < 0)
        {
            Console.WriteLine("Invalid option: " + amount);
            continue;
        }
        else if (amount == 0)
        {
            return 0;
        }
        else
        {
            validoption = true;
            return amount;
        }
    }
    return 0;

}
static float Withdraw(float balance)
{
    bool validoption = false;
    while (validoption != true)
    {
        Console.WriteLine("****************");
        Console.WriteLine("Please enter an amount to withdraw");
        Console.WriteLine("****************");
        float amount = float.Parse(Console.ReadLine());

        if (amount > balance)
        {
            Console.WriteLine("Insufficent Funds");
            continue;
        }
        else if (amount < 0)
        {
            Console.WriteLine("Invalid option: " + amount);
            continue;
        }
        else if (amount == 0)
        {
            return 0;
        }
        else
        {
            validoption = true;
            return amount;
        }
    }
    return 0;

}


static void Main()
{
    float balance = 0;
    bool is_running = true;

    while (is_running)
    {
        Console.WriteLine("****************");
        Console.WriteLine("Welcome to Banking App in C#");
        Console.WriteLine("****************");
        Console.WriteLine("1. Get Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Please enter an option (1-4): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Get_Balance(balance);
        }
        else if (choice == "2")
        {
            balance += Deposit();
        }
        else if (choice == "3")
        {
            balance -= Withdraw(balance);
        }
        else if (choice == "4")
        {
            Console.WriteLine("Thank you! Come again!");
            is_running = false;
        }
    }
}

Main();