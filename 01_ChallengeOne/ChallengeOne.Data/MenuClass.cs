using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Menu
    {
     public Menu(){}
    //Also the syntax ^^ above is meant to be 'inputs' (if that's wrong, I know, but it makes sense to thevocabulary in which my brain is resonating it.)
     public Menu(string mealName, string mealDescription, string mealIngredients, string mealPrice)
     {
         MealName = mealName;
         MealDescription = mealDescription;
         MealIngredients = mealIngredients;
         MealPrice = mealPrice;
     }   
     //properties: just, Just, JUST describes the DEVELOPER, like a damn narcissist GAH-LEE.
     public int ID { get; set; }
     public string MealName {get; set; }
     //                To read^  To Write^
     public string MealDescription { get; set; }
     public string MealIngredients { get; set; }
     public string MealPrice { get; set; }
    }