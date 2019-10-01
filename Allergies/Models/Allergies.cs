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

        public string ShowAllergens(double userValue)
        {
            double index = Math.Log(2.0, userValue);
            
            return AllergenList[(int)index];
        }
        
    }
}