using hms.BO;
using hms.Models;
using Microsoft.AspNetCore.Mvc;

namespace hms.Controllers
{
    public class UserMasterController : BaseController
    {
        private UserMasterBO UserMasterBO;
        public UserMasterController(UserMasterBO UserMasterBO) : base(UserMasterBO)
        {
            this.UserMasterBO = UserMasterBO;
        }
        [HttpPost]
        public IActionResult CreateUpdate(UserMaster rec)
        {
            var result = UserMasterBO.CreateUpdate(rec);
            return View("AddEdit", result);
        }

        public IActionResult AddEdit(int AutoId)
        {
            return View(UserMasterBO.AddEdit(AutoId));
        }
    }
}