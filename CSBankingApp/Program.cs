


static void Get_Balance(float balance)
{
    Console.WriteLine("****************");
    Console.WriteLine("Your balance is $" + balance);
    Console.WriteLine("****************");

}

static float Deposit()
{
    Console.WriteLine("****************");
    Console.WriteLine("Please enter an amount to deposit");
    Console.WriteLine("****************");
    float amount = float.Parse(Console.ReadLine());
    return amount;
}
static float Withdraw(float balance)
{
    Console.WriteLine("****************");
    Console.WriteLine("Please enter an amount to withdraw");
    Console.WriteLine("****************");
    float amount = float.Parse(Console.ReadLine());
    return amount;
}


static void Main(string[] args)
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

    }
}