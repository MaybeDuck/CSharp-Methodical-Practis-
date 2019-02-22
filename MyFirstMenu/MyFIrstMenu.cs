using System;

class Program
{

    public static void Main()
    {
        PrintMenu();
        HandleUserInput();
    }

    private static void PrintMenu()
    {
        Console.WriteLine("▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆");
        Console.WriteLine("╒════════════════════════════════════════════════════╕");
        Console.WriteLine("│" + "Welcome to the project directory".PadLeft(42) + "│".PadLeft(11));
        Console.WriteLine("╘════════════════════════════════════════════════════╛\n\n");
        Console.WriteLine("▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔");
        PrintConsoleOptions("Sleep Simulator", "Calculator", "Geuss my Number", "Elevator Scramble", "Test");
        Console.WriteLine("▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔");
    }

    private static void PrintHeader(string header)
    {
        Console.WriteLine("▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆");
        Console.WriteLine("╒════════════════════════════════════════════════════╕");
        Console.WriteLine("│" + header.PadLeft(42) + "│".PadLeft(11));
        Console.WriteLine("╘════════════════════════════════════════════════════╛\n\n");
        Console.WriteLine("▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔▔");
    }

    private static void PrintConsoleOptions(string optionA, string optionB, string optionC, string optionD, string optionE)
    {
        Console.WriteLine(1 + "┠ " + optionA.ToUpper());
        Console.WriteLine(2 + "┠ " + optionB.ToUpper());
        Console.WriteLine(3 + "┠ " + optionC.ToUpper());
        Console.WriteLine(4 + "┠ " + optionD.ToUpper());
        Console.WriteLine(5 + "┠ " + optionE.ToUpper());
    }


    private static void HandleUserInput()
    {
        int choice;
        bool isValid = false;

        do
        {
            Console.Write("Please enter an Numberical value:");
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out choice);

            if (!isValid)
            {
                Console.WriteLine("The character " + input + " is not an numerical option... Please try again..");
            }

        } while (!isValid);

        Console.WriteLine("\n\n\n\n");

        switch (choice)
        {
            case 1:
                SleepSimulator();
                break;
            case 2:
                Calculater();
                break;
            case 3:
                Console.WriteLine("This option has no support yet...");
                break;
            case 4:
                Console.WriteLine("This option has no support yet...");
                break;
            default:
                Console.Clear();
                Console.WriteLine("The choice made: " + choice + " is invalid.. Please try again..");
                PrintMenu();
                HandleUserInput();
                break;
        }
    }

    // This method is the start of the game, and handles the main execution of the game.
    private static void SleepSimulator()
    {
        //Console.Clear();
        Console.WriteLine("===========================");
        Console.WriteLine("Welcome to the sleep sim");
        Console.WriteLine("===========================");
        Console.WriteLine("\n\n");
        Console.Write("How many Hours do you want to sleep for: ");

        int NumberOfHours = GetInputForSleepSimulator();

        for (int i = 0; i < NumberOfHours; i++)
        {
            Console.WriteLine(GetSheepMessage(i));
        }

        LeaveSleepSim();

    }


    private static string LeaveSleepSim()
    {
        Console.Writeline("Press Any Key to Leave");

        Console.ReadLine();
        Console.WriteLine("Consle.read");
        Console.Read();
    }
    // Use this method to get the number of sheep to print.
    private static int GetInputForSleepSimulator()
    {
        string input = Console.ReadLine();
        int.TryParse(input, out int usrValue);
        return usrValue;
    }

    // Use this method to print the message for the sheep...
    // We're going to be printing Baa if its even, and value + "... sheep" if its odd.
    private static string GetSheepMessage(int value) 
    {

        if (value % 2 == 0)
        {
            return "baa";
        }
        else
        {
            return value + " Sheep";
        }

    }

    private static void Calculater()
    {
        Console.Clear();
        PrintHeader("Welcome to EL'Numberito");
        Console.WriteLine("+| Addtion");
        Console.WriteLine("-| Subtraction");

        Console.WriteLine("Pick An Option");
        string operation = GetInputCalculater();
        HandleCalculatorInput(operation);


    }

    private static string GetInputCalculater()
    {
        return Console.ReadLine();
    }

    private static void HandleCalculatorInput(string operation)
    {
        
        switch(operation)
        {
            case "+":
                Console.Clear();
                Console.WriteLine("You Chose addtion, sweet");
                Console.WriteLine("Enter your first number");
                string firstNumber = GetInputCalculater();
                Console.WriteLine("Enter your secound number");
                string SecoundNumber = GetInputCalculater();
                Console.WriteLine(firstNumber + " + " + SecoundNumber + " = " + Add(firstNumber, SecoundNumber));
                break;
            case "-":
                break;
        }

    }

    private static int Add(string firstNumber, string SecoundNumber)
    {
        int.TryParse(firstNumber, out int firstValue);
        int.TryParse(SecoundNumber, out int secoundValue);
        return firstValue + secoundValue;

    }

}