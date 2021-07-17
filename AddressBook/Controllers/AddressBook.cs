using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookApp.Models;

namespace AddressBookApp.Controllers
{
    public class AddressBook : Controller
    {
        public IActionResult Index()
        {            
            AddressList abook = new();
            
            abook.Addresses.Add(new Address {
                Name = "Joe",
                Address1 = "澳門", Address2 = "海洋花園",
                City = "Macau", State = "-", ZipCode = "n/a",
                Email = "joefong@gmail.com",
                Phone = "2812 3456"});
            
            abook.Addresses.Add(new Address
            {
                Name = "Cake Cake",
                Address1 = "澳門",
                Address2 = "海洋花園杏花苑",
                City = "氹仔",
                State = "-",
                ZipCode = "n/a",
                Email = "joefong@gmail.com",
                Phone = "2812 3456"
            });

            return View(abook);
        }
    }
}
