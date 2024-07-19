using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rento.Models;
using Rento.Data;
namespace Rento.Controllers
{
    public class HomeController : Controller
    {
        public RentoContext _dbContext;

        public HomeController()
        {
            _dbContext = new RentoContext();
        }
      
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Car_List()
        {
            List<Car> carList = _dbContext.Cars.ToList();
            return View(carList);
        }
      
        public ActionResult Car_Info(int id)
        {
            var car = _dbContext.Cars.Find(id);
            return View(car);
        }
       
    }
}