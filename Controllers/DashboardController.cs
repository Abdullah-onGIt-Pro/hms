using Microsoft.AspNetCore.Mvc;

namespace hms.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}