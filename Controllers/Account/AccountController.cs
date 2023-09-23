using Microsoft.AspNetCore.Mvc;
using TestApplication.ApplicationDB;
using TestApplication.Models.ViewModel;
using TestApplication.Models.Account;

namespace TestApplication.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly DbConnection context;

        public  AccountController(DbConnection context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginSignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data=
            }
            else
            {
                return View(model);

            }
        }


        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(LoginSignupViewModel model)
        {
            return View();
        }
    }
}
