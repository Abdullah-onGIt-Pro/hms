using hms.BO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace hms.Controllers
{
    public class BaseController : Controller
    {
        protected hmsViewBag hmsViewBag;
        protected BaseBO baseBO;
        public BaseController(BaseBO baseBO)
        {
            this.baseBO = baseBO;

        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = RedirectToAction(nameof(AccountController.Login), "Account");
            }
            else
            {
                hmsViewBag = new hmsViewBag();
                var ActionDescriptor = (Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor;

                hmsViewBag.controllerName = ActionDescriptor.ControllerName;
                hmsViewBag.actionName = ActionDescriptor.ActionName;
                ViewBag.hmsViewBag = hmsViewBag;
            }
            base.OnActionExecuting(context);
        }

        public virtual IActionResult Index()
        {

            return View(baseBO.GetIndexData("UserMaster"));
        }
       
        public virtual IActionResult AddEdit(int id)
        {

            return View(baseBO.GetAddEditData(id,hmsViewBag.controllerName));
        }
    }
}