using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL1
{

    public class Customer
    {
        public Customer()
        {
           
        }

        public Customer(int customerId)
        {
            CustomerId = CustomerId;
        }

        public string FirstName { get; set; }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName)) 
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName; 
                //return LastName + ", " + FirstName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;

        }
    }

}
