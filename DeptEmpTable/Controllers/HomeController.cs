using DeptEmpTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeptEmpTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult GetData()
        {
            using(DepartmentDBEntities  deptEntity = new DepartmentDBEntities())
            {
                var DeptList =  deptEntity.DepartmentTs.ToList<DepartmentT>();
                return Json(new {data=DeptList} , JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Trial()
        {
            return View("GetData");
        }

    }
}