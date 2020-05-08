using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class Customer : EntityBase
    {
        public Customer(): this(0)
        {

        }

        public Customer(int custmerId)
        {
            CustomerId = custmerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }

        public List<Address> AddressList { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public string FullName {
            get
            {
                var fullName = FirstName;
                if(!string.IsNullOrEmpty(LastName))
                {
                    if(!string.IsNullOrEmpty(FirstName))
                    {
                        fullName += ", ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }


        public static int InstanceCount { get; set; }

        //backing field
        private string _lastName;

        //C# property
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string Email { get; set; }

        


        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
            //var isValid = true;
            //if (string.IsNullOrWhiteSpace(LastName) ) isValid = false;
            //if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;

            //return isValid;
        }

    }
}
