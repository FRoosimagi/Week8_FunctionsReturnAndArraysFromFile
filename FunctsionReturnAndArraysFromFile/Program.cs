using System;

namespace FunctsionReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            displayRandomFood();
            displayRandomdrinks();
            displayRandomMovie();
        }

        private static void displayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFoods = foods[randomIndex];
            Console.WriteLine($"computer picked: {randomFoods}");
        }

        private static void displayRandomdrinks()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrinks = drinks[randomIndex];
            Console.WriteLine($"computer picked: {randomDrinks}");
        }

        private static void displayRandomMovie()
        {
            string[] Movies = { "Deadpool", "Fast and Furious", "Initial D", "Free Guy", "Jumanji" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Movies.Length);

            string randomMovies = Movies[randomIndex];
            Console.WriteLine($"computer picked: {randomMovies}");
        }
    }
}
