using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class CustomerRepository
    {
        private List<CustomerClass> customers = new List<CustomerClass>()
        {
            new CustomerClass("Adam", "Johnson", "Potential Customer", "We currently have the lowest rates on Helicopter Insurance!"),
            new CustomerClass("Austin", "Smith", "Past Customer", "  It's been a long time since we've heard from you, we want you back"),
            new CustomerClass("John", "Brown", "Current Customer", "Thank you for your work with us. We appreciate your loyalty. Here's a coupon."),
        };


        //Add Customer
        public void AddCustomerToList(CustomerClass customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(string firstName)

        {
            //customers.Remove(customer);

            int index = 0;
            foreach (CustomerClass currentCustomer in customers)
            {
                if (currentCustomer.FirstName == firstName)
                {
                    index = customers.IndexOf(currentCustomer);
                }

            }
            customers.RemoveAt(index)






        }

        public void UpdateCustomer(CustomerClass customer)
        {
            // itierated through private customer list
            // if logic statement checking that the parameter == current cutstomer of the iteration loop

            // 

            customer.(customer);
        }
        public List<CustomerClass> getList()
        {
            return customers;
        }
    }
}
