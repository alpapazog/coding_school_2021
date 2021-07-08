using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApp.Library {
    public class CustomerService : ICustomerService {
        public List<Customer> CustomerList {get; set;}
        public CustomerService() {
            JsonCustomerHandler j = new JsonCustomerHandler();
            CustomerList = j.DeserializeFromJson();
        }

        public List<Customer> LoadCustomers() {
            return CustomerList;
        }

        public void SaveCustomers() {
            JsonCustomerHandler j = new JsonCustomerHandler();
            j.SerializeToJson(CustomerList);
        }
    }
}
