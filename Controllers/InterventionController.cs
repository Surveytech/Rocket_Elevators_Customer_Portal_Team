using Rocket_Elevators_Customer_Portal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]

    public class InterventionController : Controller
    {
        // GET: InterventionController
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public async Task<ActionResult> Index()
        {
            var userName = User.Identity.Name;

            Customers customers = new Customers();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://csl-restapiweek-9.azurewebsites.net/customer/" + userName))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine("----------------------api Response--------------------");
                    System.Diagnostics.Debug.WriteLine(apiResponse);
                    customers = JsonConvert.DeserializeObject<Customers>(apiResponse);
                }
            }
            System.Diagnostics.Debug.WriteLine("----------------------customersssssssssss--------------------");
            System.Diagnostics.Debug.WriteLine(customers);
            return View(customers);
        }

        //string Baseurl = "https://csl-restapiweek-9.azurewebsites.net/";
        //public async Task<ActionResult> Index()
        //{
        //    List<Interventions> EmpInfo = new List<Interventions>();

        //    using (var client = new HttpClient())
        //    {
        //        //Passing service base url  
        //        client.BaseAddress = new Uri(Baseurl);

        //        client.DefaultRequestHeaders.Clear();
        //        //Define request data format  
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
        //        HttpResponseMessage Res = await client.GetAsync("api/Employee/GetAllEmployees");

        //        //Checking the response is successful or not which is sent using HttpClient  
        //        if (Res.IsSuccessStatusCode)
        //        {
        //            //Storing the response details recieved from web api   
        //            var EmpResponse = Res.Content.ReadAsStringAsync().Result;

        //            //Deserializing the response recieved from web api and storing into the Employee list  
        //            EmpInfo = JsonConvert.DeserializeObject<List<Interventions>>(EmpResponse);

        //        }
        //        //returning the employee list to view  
        //        return View(EmpInfo);
        //    }
        //}




        // GET: InterventionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InterventionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterventionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InterventionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InterventionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InterventionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InterventionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
