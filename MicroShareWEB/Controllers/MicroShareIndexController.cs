using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroShareWEB.Controllers
{
    public class MicroShareIndexController : Controller
    {
        //
        // GET: /MicroShareIndex/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutAPP()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();

        }
        //public JsonResult Test1()
        //{
        //    List<int> num1 = new List<int>();
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        num1.Add(i);
        //    }
        //    return Json(num1);
        //}
        //public JsonResult Test2()
        //{
        //    List<int> num2 = new List<int>();
        //    for (int j = 2; j < 1000; j++)
        //    {
        //        num2.Add(j);
        //    }
        //    return Json(num2);
        //}
    }
}
