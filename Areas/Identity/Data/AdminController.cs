using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Keyboard_Cats.Areas.Identity.Data;

namespace Keyboard_Cats.Areas.Identity.Data
{
    public class AdminController : Controller
    {
        private UserManager<Keyboard_CatsUser> _userManager;
        private object userManager;

        public AdminController(UserManager<Keyboard_CatsUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                Keyboard_CatsUser appUser = new Keyboard_CatsUser
                {
                    UserName = user.Username,
                    Email = user.Email
                };

                IdentityResult result = await userManager.CreateAsync(Keyboard_CatsUser, user.Password);

                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }
    }
}
