using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
  public  class ProgramUI
    {

        OutingRepository outingRepo = new OutingRepository();
        private List<Outing> tempList = new List<Outing>();

        public void run()
        {
            InitialPrompt();
        }

        public void InitialPrompt()
        {
            Console.WriteLine("Please Select an Option: \n 1) Combine Cost of all Outings \n 2) Display List of Outings and Cost of Each \n 3) Add an Outing");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                TotalCostPerOuting();
            }
            else if (option == 2)
            {
                DisplayList();
            }
            else if (option == 3)
            {
                AddOuting();
            }
        }

        private void TotalCostPerOuting()
        {

            Console.WriteLine("The total from all outings is: " + outingRepo.TotalCostPerOuting());
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();


        }

        private void DisplayList()
        {
            tempList = outingRepo.GetOutings();
            foreach (Outing item in tempList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();


        }
        private void AddOuting()
        {
            Console.WriteLine("Which outing did you participate in?");
            string eventType = Console.ReadLine();
            Console.WriteLine("How many employees attended the outing?");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What was the total cost of the outing?");
            double totalCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the date of the outing. PLease write in thi format. mm/dd/yyyy");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Outing newOuting = new Outing(eventType, numberOfPeople, totalCost, date);
            outingRepo.AddOutingToList(newOuting);
            Console.Clear();
            InitialPrompt();

        }
        }
    }

