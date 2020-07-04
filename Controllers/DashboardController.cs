using Microsoft.AspNetCore.Mvc;

namespace hms.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController():base(null){

        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}