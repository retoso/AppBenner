using System;

public class UserInterface : IMicrowaveUI
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
