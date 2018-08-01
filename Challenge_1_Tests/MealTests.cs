using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class MealTests
    {
        //MenuRepository menuRepo = new MenuRepository();

        [TestMethod]
        public void MenuRepository_GetList_ShouldBeTheSame()

        {
            //--Arrange
            MenuRepository menuRepo = new MenuRepository();
            List<MenuItems> list = menuRepo.GetList();
            //--Act
            int actual = list.Count;

            int expected = 4;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MenuRepository_AddItem_CountShouldIncrease()
        {
            //--Arrange
            MenuItems newItem = new MenuItems(4, "Hot Dog", "Hotdog on a hotdog bun", "One cooked hotdog on a hotdog bun with your choice of ketchup or mustard", 2.99);
            MenuRepository menuRepo = new MenuRepository();
            menuRepo.AdditemToMenu(newItem);
            List<MenuItems> list = menuRepo.GetList();
            //--Act
            int actual = list.Count;

            int expected = 5;
            //--Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void MenuRepository_RemoveItemFromList_ShouldDeccreaseCount()
        {
            //--Arrange
            MenuItems removeItem = new MenuItems(4, "Hot Dog", "Hotdog on a hotdog bun", "One cooked hotdog on a hotdog bun with your choice of ketchup or mustard", 2.99);
            MenuRepository menuRepo = new MenuRepository();
            List<MenuItems> list = menuRepo.GetList();
            menuRepo.AdditemToMenu(removeItem);
            menuRepo.RemoveitemsFromList(removeItem);

            //--Act
            int actual = list.Count;
            int expected = 3;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuRepository_AddItemList_CountShouldIncrease()
        {
            //-- Arrange
            MenuItems newItem = new MenuItems(4, "Hot Dog", "Hotdog on a hotdog bun", "One cooked hotdog on a hotdog bun with your choice of ketchup or mustard", 2.99);
            MenuRepository menuRepo = new MenuRepository();
            List<MenuItems> newList = new List<MenuItems>();
            newList.Add(newItem);
            menuRepo.AdditemToMenu(newItem);

            List<MenuItems> menuList = menuRepo.GetList();
            //-- Act
            int actual = menuList.Count;

            int expected = 4;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

       

