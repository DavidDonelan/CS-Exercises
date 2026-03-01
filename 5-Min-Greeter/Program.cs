var end = DateTime.Now.AddMinutes(5);

Console.WriteLine("App started successfully!");

try
{
    while (DateTime.Now < end)
    {
        Console.WriteLine("\nWelcome! Please choose an option:");
        Console.WriteLine("  Type '1' or 'hello'  → Say Hello");
        Console.WriteLine("  Type '2' or 'exit'   → Quit the app");

        string choice = Console.ReadLine();

        if (choice == "1" || choice == "hello") Console.WriteLine("Hello!");
        else if (choice == "2" || choice == "exit") break;
        else Console.WriteLine("Invalid input. Please type '1' or 'hello' to greet, or '2' or 'exit' to quit.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

Console.WriteLine("Goodbye!");