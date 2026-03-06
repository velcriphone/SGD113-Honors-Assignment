using System;

namespace GitTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Hungry!");

            Console.WriteLine("I'm Dad!");

            string hi = Console.ReadLine();

            if (hi == "42")
            {
                Console.WriteLine("I see you know the truth, child.");
            }
            else
            {
                Console.WriteLine("\nYeah, kiddo.");
            }

            var foods = new string[]
            {
                "Fertilized Egg Ice Cream",
                "Dirt Flavored Ants",
                "Raw Sardine Stew",
                "Prehistoric Rock",
                "Marinated Crickets"
            };

            Console.WriteLine("\nWhat food do you want to eat? Pick a number:");

            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {foods[i]}");
            }

            Console.Write("Enter number (or name): ");
            string choice = Console.ReadLine();

            string selected = null;
            if (int.TryParse(choice, out int idx) && idx >= 1 && idx <= foods.Length)
            {
                selected = foods[idx - 1];
            }
            else if (!string.IsNullOrWhiteSpace(choice))
            {
                for (int i = 0; i < foods.Length; i++)
                {
                    if (string.Equals(choice.Trim(), foods[i], StringComparison.OrdinalIgnoreCase))
                    {
                        selected = foods[i];
                        break;
                    }
                }
            }

            if (selected != null)
            {
                Console.WriteLine($"\nYou chose: {selected}. Brave choice!");
            }
            else
            {
                Console.WriteLine("\nThat's not on the menu. You get mom instead.");
            }

            Console.ReadLine();
        }
    }
}
