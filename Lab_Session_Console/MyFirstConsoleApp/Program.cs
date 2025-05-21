using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Activity 1: "Hello, C# Console!"
            #region
            Console.WriteLine("Hello, C# World from the Console!");
            Console.WriteLine("My programming journey begins now.");
            #endregion


            //Activity 3: Understanding Basic Data Types
            #region
            //int myAge = 30;
            /*double itemPrice = 19.99;
            string userName = "Alex";
            bool isLoggedIn = true;
            Console.WriteLine(myAge);
            Console.WriteLine(itemPrice);
            Console.WriteLine(userName);
            Console.WriteLine(isLoggedIn);
            */
            #endregion

            //Activity 4: Console Input and Output
            #region
            Console.WriteLine("Please enter your favorite color:");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is: " + favoriteColor);
            #endregion


            //Activity 6: Declaring and Using a Variable
            #region
            int numberOfApples = 5;
            int numberOfOranges = 3;
            int totalFruits = numberOfApples + numberOfOranges;
            Console.WriteLine("Total fruits: " + totalFruits);
            #endregion

            //Activity 9: Static Typing Exploration (Conceptual)

            #region
            int userScore = 100;
            // userScore = "High Score"; // This line is commented out
            Console.WriteLine(userScore);

            #endregion



        }
    }
}
