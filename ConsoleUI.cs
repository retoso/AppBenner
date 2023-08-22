using System;

public class ConsoleUI : IMicrowaveUI
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string GetInput()
    {
        return Console.ReadLine();
    }
}
