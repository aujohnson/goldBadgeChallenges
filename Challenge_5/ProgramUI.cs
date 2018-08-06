using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class ProgramUI
    {
        CustomerRepository _customerRepo = new CustomerRepository();
        private List<CustomerClass> tempList = new List<CustomerClass>();
        string firstName;

        public void run()
        {
            InitialPrompt();
        }

        //CustomerClass

        public void InitialPrompt()
        {
            //begin while
            //bool AddNewCustomerToList = true;
            //while (AddNewCustomerToList)
            Console.WriteLine("Please select an option: \n 1)Add Customer to list \n 2)View list \n 3)Update list \n 4) Delete profile");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                AddNewCustomerToList();
            }
            else if (option == 2)
            {
                DisplayList();
            }
            else if (option == 3)
            {
                UpdateList();
            }
            else if (option == 4)
            {
                DeleteCustomer();
            }
            else 
            {
                Exit();
                
            }

            
            //(option == 5)
            // break;
            //end while //break;
        }


        public void AddNewCustomerToList()
        {
            Console.Clear();
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            {
                int choice = Convert.ToChar(Console.ReadLine());

                {
                    switch (choice)
                    {
                        case 1:
                            AddNewCustomerToList();
                            break;
                        case 2:
                            DisplayList();
                            break;
                        case 3:
                            UpdateList();
                            break;
                        case 4:
                            DeleteCustomer();
                            break;

                    }
                    Console.Clear();
                    Console.WriteLine("Have a nice day!");
                }
            }

            //switch(x)


            //switch (Type)
            //{
            //    case 1:
            //        customerType = Type.Current;
            //}
        }

        public void DisplayList()
        {
            
            foreach (CustomerClass customer in _customerRepo.getList())
            {
                Console.WriteLine(customer);
                Console.ReadLine();
            }
           
        }


        public void UpdateList()
        {
            
            List<CustomerClass> customers = _customerRepo.getList();
            int index = customers.FindIndex(x => x.FirstName == firstName);
            CustomerClass edit = new CustomerClass("firstName", "lastName", "type", "email");
            Console.WriteLine("What would you like to update name to");
            Console.ReadLine();
            string newName = Console.ReadLine();
            customers[index].FirstName = newName;

        }

        public void DeleteCustomer()
        {

            Console.WriteLine("Which customer would you like to delete?");
            string firstName = Console.ReadLine();
            _customerRepo.RemoveCustomerByFirstName(firstName);

            List<CustomerClass> customers = _customerRepo.getList();
            int index = customers.FindIndex(x => x.FirstName == firstName);
            string removeCustomer = Console.ReadLine();
            customers.RemoveAt(index);

        }
        public void Exit()
        {

        }


    }
}

