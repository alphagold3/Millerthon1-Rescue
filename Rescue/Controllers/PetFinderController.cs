using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rescue.Controllers
{
    public class PetFinderController : Controller
    {
        public IActionResult Index()
        {

            ////var test = new
            ////{
            ////     token = "d"
            ////    ,tokenHash = "d"
            ////    ,objectType = "events"
            ////    ,objectAction = "define"
            ////};


            //HttpClient client = new HttpClient();

            //HttpResponseMessage response = await client.GetAsync();

            //Console.WriteLine(response);




            return View();
        }
    }
}