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
            double reducer = userValue;
            string allergenList= "";
            
            while ((int)reducer > 0)
            {
                double index = Math.Log(reducer, 2.0);
                Console.WriteLine(reducer);
                Console.WriteLine(index);
                reducer = reducer - Math.Pow(2.0, (int)index);
                allergenList += AllergenList[(int)index] + ", ";
            }
            allergenList = allergenList.Substring(0,allergenList.Length-2);            
            
            return allergenList;
        }
        
    }
}