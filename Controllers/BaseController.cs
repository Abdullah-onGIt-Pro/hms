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
        }
    }
}