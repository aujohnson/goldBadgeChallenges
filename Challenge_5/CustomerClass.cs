﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
   public class CustomerClass
    {
        //Constructor
        public CustomerClass(string firstName, string lastName, string type, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            Email = email;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }




        public override string ToString()
        {
            return $"First Name: {FirstName}\n" +
                             $"Last Name: {LastName}\n" +
                             $"Customer type: {Type}\n" +
                             $"Expected email: {Email}\n";
        }
    }
}
