using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuRepository
    {
        //Labels
        public List<MenuItems> _menuItems = new List<MenuItems>();

        //Methods
        public void AdditemToMenu(MenuItems items)
        {
            _menuItems.Add(items);
        }
        public List<MenuItems> GetList()
        {
            return _menuItems;
        }
        public MenuItems FinditemsByName(string mealName)
        {
            MenuItems items = new MenuItems();

            foreach (MenuItems menuItems in _menuItems)
            {
                if (mealName == menuItems.MealName)
                    items = menuItems;
            }
            return items;
        }
        public void RemoveitemsFromList(MenuItems items)
        {
            _menuItems.Remove(items);
        }
        
    }     
}
