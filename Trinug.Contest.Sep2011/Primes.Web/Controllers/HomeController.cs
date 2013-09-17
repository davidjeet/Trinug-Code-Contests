using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primes.Model;
using System.Diagnostics;
using System.Text;

namespace Primes.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly int LIMIT_OF_PRIMES = 100000; 

        public ActionResult Index()
        {
            //Compute (and time) all primes from 0 - 100000
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var list = ComputePrimes.ReturnPrimes(LIMIT_OF_PRIMES);
            sw.Stop();

            //Display/UI related code
            StringBuilder sb = new StringBuilder("");
            ViewBag.TimeTaken =  String.Format("Time taken: {0} milliseconds. Number of primes returned: {1}", sw.ElapsedMilliseconds, list.Count);
            foreach (var item in list)
            {
                sb.AppendFormat("{0}{1}", item, " ");
            }
            ViewBag.Message = sb.ToString();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
