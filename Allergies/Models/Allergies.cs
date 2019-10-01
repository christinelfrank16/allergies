using System.Collections.Generic;
using System;
namespace Allergies.Models
{
    public class Allergen
    {
        List<string> AllergenList { get; }
        public Allergen()
        {
            AllergenList = new List<string>() { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats" };
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
            double index = Math.Log(2.0, userValue);
            
            return AllergenList[(int)index];
        }
        
    }
}