using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableActivities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------
            // Activity 1: Numeric Variable Declaration and Initialization
            // ----------------------------
            int studentCount = 25;
            double averageScore = 88.7;
            decimal accountBalance = 1234.56m;

            Console.WriteLine("Number of students: " + studentCount);
            Console.WriteLine("Average score: " + averageScore);
            Console.WriteLine("Account balance: $" + accountBalance);
            // Why use decimal for accountBalance?
            // Decimal provides higher precision, which is critical for financial calculations to avoid rounding errors.

            // ----------------------------
            // Activity 2: String Variable and Concatenation
            // ----------------------------
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name: " + fullName);

            // Alternative using string interpolation
            string fullNameAlt = $"{firstName} {lastName}";
            Console.WriteLine("Full Name (interpolated): " + fullNameAlt);

            // ----------------------------
            // Activity 3: Type Conversion with Convert.ToInt32()
            // ----------------------------
            string ageString = "30";
            int ageNumeric = Convert.ToInt32(ageString);
            Console.WriteLine("Age in 5 years: " + (ageNumeric + 5));

            // Try changing ageString to "thirty" and observe
            // string ageString = "thirty"; // Uncomment this line to test
            // int ageNumeric = Convert.ToInt32(ageString); // This will throw a FormatException

            // ----------------------------
            // Activity 4: Type Conversion with double.Parse()
            // ----------------------------
            string priceString = "49.99";
            double priceNumeric = double.Parse(priceString);
            Console.WriteLine("Discounted price (10% off): " + (priceNumeric * 0.9));

            // Now test int.Parse("12.50")
            // int badParse = int.Parse("12.50"); // This throws FormatException because "12.50" is not a valid int

            // ----------------------------
            // Activity 5: Safe Type Conversion with int.TryParse()
            // ----------------------------
            Console.Write("Enter a whole number: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userNumber))
            {
                Console.WriteLine("You entered the number: " + userNumber);
            }
            else
            {
                Console.WriteLine("That was not a valid whole number.");
            }

            // ----------------------------
            // Activity 6: Explicit Casting and Potential Data Loss
            // ----------------------------
            double preciseValue = 123.789;
            int roundedValue = (int)preciseValue;

            Console.WriteLine("Precise value: " + preciseValue);
            Console.WriteLine("Rounded value: " + roundedValue);
            // Decimal part (.789) is lost during casting, which is important in scenarios where precision matters.

            // ----------------------------
            // Activity 7: Basic String Properties and Methods
            // ----------------------------
            string message = " Hello, C# World! ";
            Console.WriteLine("Original length: " + message.Length);
            Console.WriteLine("Uppercase: " + message.ToUpper());
            Console.WriteLine("Lowercase: " + message.ToLower());
            Console.WriteLine("Trimmed message: '" + message.Trim() + "'");
            // Original length includes leading and trailing spaces.

            // ----------------------------
            // Activity 8: String Manipulation with Replace and Substring
            // ----------------------------
            string sentence = "C# is fun and C# is powerful.";
            string replacedSentence = sentence.Replace("C#", "CSharp");
            Console.WriteLine("Replaced Sentence: " + replacedSentence);

            int startIndex = sentence.IndexOf("fun");
            string word = sentence.Substring(startIndex, 3);
            Console.WriteLine("Extracted word: " + word);
            // Arguments to Substring: start index = position of "fun", length = 3
        }
    }
}
