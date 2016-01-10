using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace RoutingLab.Controllers
{
    public class PurchaseController : Controller
    {
        public string Index()
        {
            return "Purchase/Index";
        }

        [Route("orders/index")]
        public string ShowAll()
        {
            return "Purchase/ShowAll";
        }

        [Route("orders/details/{id:int}")]
        public string Show(int id)
        {
            return "Purchase/Show/Id, id = " + id;
        }
    }
}
