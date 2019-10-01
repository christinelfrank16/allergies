using System.Collections.Generic;
using System;
namespace Allergies.Models
{
    public class Allergen
    {
        List<string> AllergenList { get; }
        List<string> UnknownAllergenList { get; }
        public Allergen()
        {
            AllergenList = new List<string>() { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats" };

            UnknownAllergenList = new List<string>(){"land wars in asia", "iocane powder", "shark dandruff", "alien bacteria", "puns", "water bears", "life", "poor grammar", "clowns", "LA Air", "bluray discs", "sunlight and garlic- btw, you're a vampire"};
        }


        public double GetUserInput(string input)
        {
            double numToReturn = 0.00;

            try{
                numToReturn = Math.Abs(Double.Parse(input));
                // ternary operator  
                numToReturn = numToReturn/(int)numToReturn == 1.0 ? numToReturn : -0.1;
            }
            catch(FormatException)
            {
                numToReturn = -0.1;
            }
            return numToReturn;
        }

        public string ShowAllergens(double userValue)
        {
            double reducer = userValue;
            string allergenList= "";
            
            while ((int)reducer > 0)
            {
                double index = Math.Log(reducer, 2.0);
                reducer = reducer - Math.Pow(2.0, (int)index);
                try
                {
                    allergenList = AllergenList[(int)index] + ", " + allergenList;
                }
                catch(ArgumentOutOfRangeException)
                {
                    allergenList += "unknown allergen, ";
                }
            }
            allergenList = allergenList.Substring(0,allergenList.Length-2);            
            
            return allergenList;
        }
        public string UnknownReplacer(string list)
        {
            Random rnd = new Random();
            int unknownAllIndex = list.IndexOf("unknown allergen");

            while(unknownAllIndex >= 0)
            {
                int index = rnd.Next(0, UnknownAllergenList.Count);
                list = list.Remove(unknownAllIndex, 16).Insert(unknownAllIndex,UnknownAllergenList[index]);
                unknownAllIndex = list.IndexOf("unknown allergen");

                // list.Replace("unknown allergen", UnknownAllergenList[])
            }

            return list;
        }
        
    }
}