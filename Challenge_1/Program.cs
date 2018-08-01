using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Identify Variables
            MenuItems salad = new MenuItems(1, "Salad", "Cesar Salad", "Lettuce, tomato, cheese, onion, cesar dressing", 4.99);
            MenuRepository menuRepo = new MenuRepository();
            menuRepo.AdditemToMenu(salad);

            MenuItems chilli = new MenuItems(2, "Chilli", "Red Pepper Chilli", "Cooked ground beef, chilli sauce, red peppers", 2.99);
            MenuItems cheeseBurger = new MenuItems(3, "Cheeseburger", "ultimate Cheeseburger", "Hamburger bun, two patties, two slices of American cheese, lettuce, ketchup", 8.99);
            MenuItems hotDog = new MenuItems(4, "Hot Dog", "Hotdog on a hotdog bun", "One cooked hotdog on a hotdog bun with your choice of ketchup or mustard", 2.99);
            MenuItems banannaPudding = new MenuItems(5, "Pudding", "Bananna Pudding", "Pudding, banannas, vanilla wafers", 3.99);


            menuRepo.AdditemToMenu(chilli);
            menuRepo.AdditemToMenu(cheeseBurger);
            menuRepo.AdditemToMenu(hotDog);
            menuRepo.AdditemToMenu(banannaPudding);

            List<MenuItems> items = menuRepo.GetList();

            foreach (MenuItems menuItems in items)
            {
                Console.WriteLine(menuItems.MealName);
            }

            Console.WriteLine("          ");

            menuRepo.RemoveitemsFromList(chilli);


            Console.WriteLine("Enter meal #");

            int number = Int32.Parse(Console.ReadLine());


            foreach (MenuItems menuItem in items)
            {
                Console.WriteLine($"MealName: {menuItem.MealName}\n" +
                    $"Meal Number :{menuItem.MealNumber} \n" +
                    $"Description: {menuItem.Description} \n" +
                    $"Ingredients: {menuItem.Ingredients}\n" +
                    $"Price: {menuItem.Price}\n");
            }

            Console.WriteLine("Enter name of food item:");
            string userAnswer = Console.ReadLine();

            Console.WriteLine("Enter meal number");
            int userMealNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter description:");
            string userDescription = Console.ReadLine();

            Console.WriteLine("Enter ingredients:");
            string userIngredients = Console.ReadLine();

            Console.WriteLine("Enter price of food item:");
            double userPrice = Double.Parse(Console.ReadLine());


            MenuItems theItem = new MenuItems(userMealNumber, userAnswer, userDescription, userIngredients, userPrice);
            menuRepo.AdditemToMenu(theItem);








        }
    }
}
    
    
