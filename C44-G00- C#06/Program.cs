using System;

class Program
{
    static void Main(string[] args)
    {
        #region "Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example"
        Console.WriteLine("=== Value Type Parameters Example ===");

        // By Value - Original variable is not modified
        int originalValue = 10;
        Console.WriteLine($"Before calling PassByValue: originalValue = {originalValue}");
        PassByValue(originalValue);
        Console.WriteLine($"After calling PassByValue: originalValue = {originalValue}");

        // By Reference - Original variable is modified
        int originalRef = 10;
        Console.WriteLine($"Before calling PassByReference: originalRef = {originalRef}");
        PassByReference(ref originalRef);
        Console.WriteLine($"After calling PassByReference: originalRef = {originalRef}");

        Console.WriteLine();
        #endregion

        #region "Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example"
        Console.WriteLine("=== Reference Type Parameters Example ===");

        // Reference type by value - can modify object contents, but not the reference itself
        int[] arrayByValue = { 1, 2, 3 };
        Console.WriteLine($"Before calling ModifyArrayByValue: array[0] = {arrayByValue[0]}");
        ModifyArrayByValue(arrayByValue);
        Console.WriteLine($"After calling ModifyArrayByValue: array[0] = {arrayByValue[0]}");

        // Reference type by reference - can modify both object contents and the reference
        int[] arrayByRef = { 1, 2, 3 };
        Console.WriteLine($"Before calling ModifyArrayByReference: array length = {arrayByRef.Length}");
        ModifyArrayByReference(ref arrayByRef);
        Console.WriteLine($"After calling ModifyArrayByReference: array length = {arrayByRef.Length}");

        Console.WriteLine();
        #endregion

        #region "Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers"
        Console.WriteLine("=== Summation and Subtraction Function ===");

        Console.Write("Enter first number: ");
        int num1 = GetValidInteger();
        Console.Write("Enter second number: ");
        int num2 = GetValidInteger();
        Console.Write("Enter third number: ");
        int num3 = GetValidInteger();
        Console.Write("Enter fourth number: ");
        int num4 = GetValidInteger();

        int sumResult, subtractResult;
        CalculateSumAndSubtract(num1, num2, num3, num4, out sumResult, out subtractResult);

        Console.WriteLine($"Sum of {num1} and {num2}: {sumResult}");
        Console.WriteLine($"Subtraction of {num3} and {num4}: {subtractResult}");

        Console.WriteLine();
        #endregion

        #region "Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number"
        Console.WriteLine("=== Sum of Individual Digits ===");

        Console.Write("Enter a number: ");
        int number = GetValidInteger();

        int digitSum = SumOfDigits(number);
        Console.WriteLine($"The sum of the digits of the number {number} is: {digitSum}");

        Console.WriteLine();
        #endregion

        #region "Create a function named IsPrime, which receives an integer number and retuns true if it is prime, or false if it is not"
        Console.WriteLine("=== Prime Number Check ===");

        Console.Write("Enter a number to check if it's prime: ");
        int primeCheck = GetValidInteger();

        bool isPrimeResult = IsPrime(primeCheck);
        Console.WriteLine($"{primeCheck} is {(isPrimeResult ? "prime" : "not prime")}");

        Console.WriteLine();
        #endregion

        #region "Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters"
        Console.WriteLine("=== Min Max Array Function ===");

        Console.Write("Enter the size of the array: ");
        int arraySize = GetValidInteger();

        int[] minMaxArray = new int[arraySize];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Element {i + 1}: ");
            minMaxArray[i] = GetValidInteger();
        }

        int min, max;
        MinMaxArray(minMaxArray, out min, out max);

        Console.WriteLine($"Minimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");

        Console.WriteLine();
        #endregion

        #region "Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter"
        Console.WriteLine("=== Factorial Calculation ===");

        Console.Write("Enter a number to calculate its factorial: ");
        int factorialNum = GetValidInteger();

        long factorial = CalculateFactorial(factorialNum);
        Console.WriteLine($"Factorial of {factorialNum} is: {factorial}");

        Console.WriteLine();
        #endregion

        #region "Create a function named ChangeChar to modify a letter in a certain position (0 based) of a string, replacing it with a different letter"
        Console.WriteLine("=== Change Character in String ===");

        Console.Write("Enter a string: ");
        string originalString = Console.ReadLine();

        Console.Write("Enter the position to change (0-based): ");
        int position = GetValidInteger();

        Console.Write("Enter the new character: ");
        char newChar = Console.ReadLine()[0];

        string modifiedString = ChangeChar(originalString, position, newChar);
        Console.WriteLine($"Original string: {originalString}");
        Console.WriteLine($"Modified string: {modifiedString}");
        #endregion
    }

    // Helper function for input validation
    static int GetValidInteger()
    {
        string input = Console.ReadLine();
        int result;
        while (!int.TryParse(input, out result))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
            input = Console.ReadLine();
        }
        return result;
    }

    // Value type by value - original variable is not modified
    static void PassByValue(int value)
    {
        value = 100;
        Console.WriteLine($"Inside PassByValue: value = {value}");
    }

    // Value type by reference - original variable is modified
    static void PassByReference(ref int value)
    {
        value = 100;
        Console.WriteLine($"Inside PassByReference: value = {value}");
    }

    // Reference type by value - can modify array contents but not the reference itself
    static void ModifyArrayByValue(int[] array)
    {
        array[0] = 999; // This modifies the original array
        array = new int[] { 100, 200, 300 }; // This does NOT affect the original reference
    }

    // Reference type by reference - can modify both array contents and the reference
    static void ModifyArrayByReference(ref int[] array)
    {
        array = new int[] { 100, 200, 300, 400, 500 }; // This DOES affect the original reference
    }

    // Function that accepts 4 parameters and returns summation and subtraction results
    static void CalculateSumAndSubtract(int a, int b, int c, int d, out int sum, out int subtract)
    {
        sum = a + b;
        subtract = c - d;
    }

    // Function to calculate sum of individual digits
    static int SumOfDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number); // Handle negative numbers

        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }

        return sum;
    }

    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number == 2)
            return true;

        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    // Function to find minimum and maximum values in an array using reference parameters
    static void MinMaxArray(int[] array, out int min, out int max)
    {
        min = array[0];
        max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];

            if (array[i] > max)
                max = array[i];
        }
    }

    // Iterative function to calculate factorial
    static long CalculateFactorial(int number)
    {
        if (number < 0)
            return -1; // Factorial is not defined for negative numbers

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    // Function to change a character at a specific position in a string
    static string ChangeChar(string str, int position, char newChar)
    {
        if (position < 0 || position >= str.Length)
        {
            Console.WriteLine("Invalid position!");
            return str;
        }

        char[] charArray = str.ToCharArray();
        charArray[position] = newChar;
        return new string(charArray);
    }
}