using hms.BO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace hms.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = RedirectToAction(nameof(AccountController.Login), "Account");
            }
            else
            {
                hmsViewBag hmsViewBag = new hmsViewBag();
                var ActionDescriptor = (Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor;

                hmsViewBag.controllerName = ActionDescriptor.ControllerName;
                hmsViewBag.actionName = ActionDescriptor.ActionName;
                ViewBag.hmsViewBag = hmsViewBag;
            }
            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {
            BaseBO baseBO = new BaseBO();

            return View(baseBO.GetIndexData("UserMaster"));
        }
    }
}