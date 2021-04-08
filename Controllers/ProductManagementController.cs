using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
    public class ProductManagementController : Controller
    {
        [Microsoft.AspNetCore.Authorization.Authorize]
        // GET: ProductManagementController
        public IActionResult Index()
        {
            return View();
        }

        // GET: ProductManagementController/Battery
        public IActionResult Battery()

        {
            return View();
        }

        // GET: ProductManagementController/Column
        public IActionResult Column()
        {
            return View();
        }

        // GET: ProductManagementController/Elevator
        public IActionResult Elevator()
        {
            return View();
        }
        public async Task<IActionResult> TestQuery()
        {
            var response = await Program.queryAsync("query getCustomerByEmail($email: String!){}")
                query($email String){ getCustomerByEmail(email: $email){ building { id battery{ id column{ id elevators{ id} } } } }
                    ViewBag.customer = response["getCustomerByEmail"];
                }
            return View();
        }

        public static async Task<bool> GetInformations(string inputEmail)
        {
            var graphQLClient = new 
        }

    }
}
