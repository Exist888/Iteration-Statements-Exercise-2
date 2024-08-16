namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintEveryThirdNumber();
            AreNumbersEqual(5, 7);
            IsEven(12);
            IsPositive(0);
            CanVote(0);
            IsInRange(0);
            DisplayMultiplicationTable(0);
        }
        
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            for (int third = 3; third <= 999; third += 3)
            {
                Console.WriteLine(third);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
                return true;
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
                return false;
            }
            else
            {
                Console.WriteLine($"0 is neither positive nor negative.");
                return false;
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static bool CanVote(int age)
        {
            Console.WriteLine("Please enter your age to see if you are eligible to vote:");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"Congrats. Being {age} makes you eligible to vote.");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, being {age} means you can't vote yet, but please come back in the future.");
                return false;
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int number)
        {
            Console.WriteLine("Please enter a whole number that is between -10 and 10:");
            number = int.Parse(Console.ReadLine());
            if (number <= 10 && number >= -10)
            {
                Console.WriteLine($"Excellent. {number} falls within the correct range.");
                return true;
            }
            else
            {
                Console.WriteLine($"{number} does not fall within the correct range.");
                return false;
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.

        public static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine("Want to see a cool multiplication table?\n" +
                              "Enter any whole number,\n" +
                              "and we will multiply it\n" +
                              "by every number from 1 to 12.\n" +
                              "\n" +
                              "Ready? Enter your number:");
            number = int.Parse(Console.ReadLine());
            
            List<int> factors = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (int factor in factors)
            {
                int product = factor * number;
                Console.WriteLine($"{number} * {factor} = {product}.");
            }
        }
    }
}
