using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class CustomerReposistory
    {

        private AddressRepository addressRepository { get; set; }

        public CustomerReposistory()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer();

            if (customerId == 1)
            {
                customer.FirstName = "Tyler";
                customer.LastName = "Dinh";
                customer.AddressList = addressRepository.RetrieveAddressByCustomerId(1).ToList();
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            //TODO
            return true;
        }
    }
}
