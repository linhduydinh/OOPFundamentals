using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class AddressRepository
    {
        public Address Retrieve(int customerId)
        {
            return new Address(1)
            {
                City = "city1",
                State = "state1"
            };
        }

        public IEnumerable<Address> RetrieveAddressByCustomerId(int customerId)
        {
            var address1 = new Address()
            {
                City = "city1",
                State = "state1"
            };

            var address2 = new Address()
            {
                City = "city2",
                State = "state2"
            };

            var listAddress = new List<Address>();
            listAddress.Add(address1);
            listAddress.Add(address2);

            return listAddress;
        }
    }
}
