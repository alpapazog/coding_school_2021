using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApp.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerApp.Pages
{
    public class AddCustomerModel : PageModel
    {   
        public Customer NewCustomer { get; set; }
        public ICustomerService _customerService { get; set; }
        public AddCustomerModel(ICustomerService customerService) {
            _customerService = customerService;
        }
        public void OnPostAddCustomer()
        {
            if (!ModelState.IsValid) {
                return;
            }

            _customerService.CustomerList.Add(NewCustomer);
            _customerService.SaveCustomers();

            RedirectToPage("./Customers");
        }
        public void OnPostCancel() {

            //System.Diagnostics.Debug.WriteLine("hellocancel");
            Redirect("~/Pages/Customers");
        }

        public IActionResult Cancel() {
            return RedirectToPage("./Customers");
        }
    }
}
