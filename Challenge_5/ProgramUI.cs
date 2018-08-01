using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class ProgramUI
    {
        CustomerRepository outingRepo = new CustomerRepository();
        private List<CustomerClass> tempList = new List<CustomerClass>();

        public void run()
        {
            InitialPrompt();
        }

        //CustomerClass

        public void InitialPrompt()
        {
            Console.WriteLine("Please select an option: \n 1)Add Customer to list \n 2)View list \n 3)Update list \n 4) Delete profile");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first name");
                    Console.ReadLine();

                    break;
            }

            int (option == 1) ;
            


        }
    }
}
