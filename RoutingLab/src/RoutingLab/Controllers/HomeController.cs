using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace RoutingLab.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int? id)
        {
            return (id.HasValue) 
                ? "In Home/Index, id = " + id
                : "In Home/Index";
        }

    }
}
