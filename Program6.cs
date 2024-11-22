string? readResult;
bool validEntry = false;

do
{
    Console.Write("Enter your role name (Administrator, Manager, or User): ");
    readResult = Console.ReadLine().Trim().ToLower();
    
    if (readResult == "administrator" || readResult == "manager" || readResult == "user")
    {
        validEntry = true;
        Console.WriteLine($"Your input value ({readResult}) has been accepted.");        
    }
    else
        Console.WriteLine("The role name that you entered, \"{readResult}\" is not valid. " +
                         "Enter your role name (Administrator, Manager, or User)");

} while (validEntry == false);
