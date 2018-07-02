using Microsoft.AspNetCore.Mvc;
using CarDealershipC.Models;

namespace CarDealershipC.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          UsedCars newCar = new UsedCars("1998", "Subaru", "Outback", "231,000", "$3,000");
            return View(newCar);
        }
    }
}
