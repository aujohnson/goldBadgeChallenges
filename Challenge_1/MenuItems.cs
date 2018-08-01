using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
   public class MenuItems
    {
        //Constructor 1

            public MenuItems() { }


        //Constructor 2

        public MenuItems(int mealNumber, string mealName, string description, string ingredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price; 
        }





        //Properties
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

    }
}
