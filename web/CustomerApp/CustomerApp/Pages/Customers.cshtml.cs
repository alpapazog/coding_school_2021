using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerApp.Pages
{
    public class CustomersModel : PageModel {
        [BindProperty]
        public List<Customer> CustomerList { get; set; }
        public ICustomerService _customerService { get; set; }
        public string Message { get; set; }

        public CustomersModel(ICustomerService customerService) {
            _customerService = customerService;
            CustomerList = _customerService.LoadCustomers();
        }
        public void OnGet()
        {
            CustomerList = _customerService.LoadCustomers();
            Message = "on get now";
        }

        public void OnPostEditCustomer() {

        }

       
    }
}
