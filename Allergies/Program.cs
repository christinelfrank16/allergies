using System;
using Allergies.Models;

class Program
{
    static void Main()
    {
        Allergen allergen = new Allergen();
        Intro(allergen);

    } 

    public static void Intro(Allergen allergen)
    {
        Console.WriteLine("What is your favorite number?");
        
        string response = "";
        
        string userNumber = Console.ReadLine();
        double num = allergen.GetUserInput(userNumber);
        if (num == -.1)
        {
            Console.WriteLine("git gud at life, try again");
            Intro(allergen);
        }
        else 
        {
            response = allergen.ShowAllergens(num);
            response = allergen.UnknownReplacer(response);
            Console.WriteLine("Your allergen list: " + response);
        }
    }
}

