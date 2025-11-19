using System.Data.SqlTypes;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers1000()
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
            for (int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }
        
        
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"Numbers {num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"Numbers {num1} and {num2} are not equal");
            }
            
        }
        
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is not even"); 
            }

            return true;
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int number2)
        {
            if (number2 > 0)
            {
                Console.WriteLine($"{number2} is positive");
            }
            else
            {
                Console.WriteLine($"{number2} is negative");
            }


            return true;
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        public static bool CanVote()
        {
            Console.WriteLine("enter age");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("enter a valid age");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }


            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats {userAge} is old enough to vote.");
            }
            else
            {
                Console.WriteLine($"sorry {userAge} is not old enough to vote.");
            }
            
            return false;
        }
        
        
        
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void TenRange()
        {
            Console.WriteLine("please give me a number");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("enter a valid number");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }
            
            if(userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"{userNumber} is in the range between 10 and -10");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the range between -10 and -10");
            }
        }
        
        
        
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void MultiplyTroughTwelve(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }
        
        
        
        
        //hod below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers1000(); // 1


             PrintEveryThirdNumber(); // 2


            AreNumbersEqual(num1: 1, num2: 2); // 3


            Console.WriteLine("enter a whole number");
            int number = Convert.ToInt32(Console.ReadLine());
           IsEven(number); // 4

            
            Console.WriteLine("enter another number to know if it is positive");
            int number2 = Convert.ToInt32(Console.ReadLine());
           IsPositive(number2); // 5


         CanVote(); // 6
          
          TenRange(); // 7
          
          MultiplyTroughTwelve(22); // 8




        }

       
    }
}
