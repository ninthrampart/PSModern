using PSModern.Models;
using PSModern.Models.DAL;
using PSModern.Models.Repository;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSModern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //PSContext db = new PSContext();
            ////db.Database.Initialize(true);

            //var a = db.Works.ToList();

            //IWorkRepository rep = new EFWorkRepository();
            //var a = rep.GetAll();

            //var client = new RestClient("http://localhost:44470/");
            //var request = new RestRequest("api/ps/GetAllWorks", Method.GET);

            //var response = client.Execute<List<Work>>(request);
            //var res = response.Data;

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