using Autofac;
using AutoFacTestWeb.AutoFacModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacTestWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(MyClass myclass)
        {
            Console.WriteLine(myclass.id);
            //IContainer container = builder.Build();
            //MyClass obj = container.Resolve<MyClass>(); //从autofac容器中获取Class_1对象
            //Console.WriteLine(obj.id);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}