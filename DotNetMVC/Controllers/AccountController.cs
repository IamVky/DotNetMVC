using System.Web.Mvc;

namespace DotNetMVC.Controllers {
    public class AccountController : Controller {
        // GET: Account
        public ActionResult Register() {
            return View();
        }
        public ActionResult Login() {
            return View();
        }
    }
}