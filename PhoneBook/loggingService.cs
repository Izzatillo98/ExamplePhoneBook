using System;

namespace PhoneBookWithFile.Services;

internal class LoggingService : ILoggingService
{
    public void LoggerMenu()
    {
        LogInformation("what do you want to do");
        LogInformation("1. Add a contact");
        LogInformation("2. Remove a contact");
        LogInformation("3. Show all contact");
        LogInformation("4. Exit ");
    }

    public void LogInformation(string message)
    {
        Console.WriteLine(message);
    }
}