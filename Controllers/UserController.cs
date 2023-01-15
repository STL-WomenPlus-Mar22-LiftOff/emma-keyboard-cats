using Keyboard_Cats.Models;
using Keyboard_Cats.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Keyboard_Cats.Controllers
{
    public class UserController : Controller
    {
      
            // GET: /<controller>/
            public IActionResult Index()
            {
                //List<User> users = new List<User>();
                return View();
            }

            public IActionResult Add()
            {
                AddUserViewModel addUserViewModel = new AddUserViewModel();
                return View(addUserViewModel);
            }

            [HttpPost]
            [Route("/user")]
            public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
            {
                if (ModelState.IsValid)
                {

                    if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                    {
                    Areas.Identity.Data.Keyboard_CatsUser newKeyboard_CatsUser = new Areas.Identity.Data.Keyboard_CatsUser
                        {
                            Username = addUserViewModel.Username,
                            Email = addUserViewModel.Email,
                            Password = addUserViewModel.Password,
                        };

                        return View("Index", newKeyboard_CatsUser);
                    }
                    else
                    {
                        ViewBag.error = "Passwords do not match.";
                        return View("Add", addUserViewModel);
                    }


                }


                return View("Add", addUserViewModel);
            }

           
        
    }
}
