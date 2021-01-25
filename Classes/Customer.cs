using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer      // Property
    {
        //field
        //public string LastName;

        // property
        public int Id { get; set; }
        public string FirstName { get; set; }

        //private string _firstName;
        //public string FirstName
        //{ 
        //    get { return "Mr." + _firstName; }  // Önemli ayrıntı   //Encapsulation
        //    set { _firstName = value; } 
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
