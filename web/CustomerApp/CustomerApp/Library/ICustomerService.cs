using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApp.Library {
    public interface ICustomerService {
        public List<Customer> CustomerList { get; set; }
        List<Customer> LoadCustomers();
        void SaveCustomers();
    }
}
