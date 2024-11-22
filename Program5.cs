using System.Runtime.InteropServices;

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter an integer number between 5 and 10:");
do
{
    readResult = Console.ReadLine();

    int numericValue = 0;
    bool validNumber = false;

    validNumber = int.TryParse(readResult, out numericValue);
    //var isNumeric = int.TryParse(readResult, out int n);
    //bool isNumeric = readResult.All(char.IsNumber);
    bool isEmpty = string.IsNullOrEmpty(readResult);
    if (readResult != null)
    {
        if(isEmpty)
            System.Console.WriteLine("Your input is empty, please try again.");
        else if(validNumber) 
        {
            int nuevo = Convert.ToInt16(readResult);
            if(nuevo >= 5 && nuevo <= 10) 
            {
                validEntry = true;
                System.Console.WriteLine($"Your input value ({nuevo}) has been accepted.");
            }
            else 
                Console.WriteLine($"You entered {nuevo}. Please enter a number between 5 and 10.");
        }           
        else
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validEntry == false);
