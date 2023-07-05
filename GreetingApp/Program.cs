

// Welcome User To App
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This application was built by Ayoub Chahir");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

// Ask for first name
Console.Write("What is your first name: ");
string firstName = Console.ReadLine();
if (firstName.IndexOf(" ") != -1)
{
    Console.Write("Please enter just your first name: ");
    firstName = Console.ReadLine();
}

// Greet user by name
Console.WriteLine();
Console.WriteLine($"Hello {firstName}");

Console.WriteLine("Thank you for using my application.");
Console.ReadLine();
