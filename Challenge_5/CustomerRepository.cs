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

        public void RemoveCustomerByFirstName(string name)
        {
            List<CustomerClass> removing = customers.FindAll(x => x.FirstName == name);
            foreach (CustomerClass cust in removing)
            {
                customers.Remove(cust);
            }
        }






    

        public void UpdateCustomer(string name, CustomerClass customer)
        {
            List<CustomerClass> updateCustomer = customers.FindAll(x => x.LastName == name);

            foreach(CustomerClass c in updateCustomer)
            {
                customers.Remove(c);
            }

            customers.Add(customer);

            // itierated through private customer list
            // if logic statement checking that the parameter == current cutstomer of the iteration loop

            // 

        }
        
        public List<CustomerClass> getList()
        {
            return customers;
        }
    }
}
