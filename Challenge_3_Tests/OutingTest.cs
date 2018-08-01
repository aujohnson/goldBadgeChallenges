using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class OutingTest
    {
        OutingRepository outingrepo = new OutingRepository();

        [TestMethod]
        public void OutingRepository_GetList_CountShouldBeTheSame()
        {
            //Arrange
            List<Outing> outingList = outingrepo.GetOutings();

            //Act
            int actual = outingList.Count;
            int expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OutingRepository_AddOuting()
        {
            //Arrange
            Outing newOuting = new Outing("Flag Football", 500, 10, DateTime.Parse("04/03/2020"));
            outingrepo.AddOutingToList(newOuting);
            List<Outing> outings = outingrepo.GetOutings();

            //Act
            int actual = outings.Count;
            int expected = 5;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OutingRepository_AddOutingToList()
        {
            //Arrange
            Outing newOuting = new Outing("Flag Football", 500, 10, DateTime.Parse("04/03/2020"));
            List<Outing> newOutings = new List<Outing>();
            newOutings.Add(newOuting);
            outingrepo.AddOutingToList(newOuting);
            List<Outing> outings = outingrepo.GetOutings();

            //Act
            int actual = outings.Count;
            int expected = 5;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OutingRepository_CalcTotalOfAllOutings()
        {
            //Arrange
            double actual;
            double expected;

            //Act
            actual = outingrepo.TotalCostPerOuting();
            expected = 40;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        }
    }

