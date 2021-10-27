using System;

namespace FraidayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            displayRandomFood();
            displayRandomdrink();
            displayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void displayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
           
            Console.WriteLine($"computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void displayRandomdrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };

            Console.WriteLine($"computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void displayRandomMovie()
        {
            string[] Movies = { "Deadpool", "Fast and Furious", "Initial D", "Free Guy", "Jumanji" };
            
            Console.WriteLine($"computer picked: {Movies[GenerateRandomIndex(Movies)]}");
        }
    }
}
