using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace RoutingLab.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "Test/Index";
        }

        public string Execute()
        {
            return "Test/Execute ";
        }
    }
}
