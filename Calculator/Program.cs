using System.Security.Cryptography;

CalculatorApp();

void CalculatorApp()
{

    // Declare the variables and initialise them to 0.
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;
    // Ask the user to input the first number
    Console.WriteLine("Type in the first number followed by the Enter Key)");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    // Ask the user to input the second number
    Console.WriteLine("Type in the second number followed by the Enter Key)");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // use a loop to make the relevant decision
    // and perform the request maths operation.
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    // Use an IF statement to perform selected maths operation.
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine("Adding {0} and {1} gives: {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} from {secondNumber} equals {result}");

    }
    else if (choice == 4)
        result = firstNumber * secondNumber;
    Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}");


    Console.WriteLine("You did not select a valid number 1-4");
    // Convert string to integer.
    choice = Convert.ToInt32(Console.ReadLine());

    //perform the calculation
    result = firstNumber + secondNumber;

    //output the answer to the console
    Console.WriteLine("The Result is: {0}", result);
}