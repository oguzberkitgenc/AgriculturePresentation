using AgriculturePresentation.Models;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

		public LoginController(UserManager<IdentityUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
        {
            
            return View();
        }
		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
		{
			IdentityUser identityUser = new IdentityUser()
			{
				Id="1",
				UserName = registerViewModel.userName,
				Email = registerViewModel.mail
			};
			if (registerViewModel.password==registerViewModel.passwordConfirm)
			{
				var result = await _userManager.CreateAsync(identityUser, registerViewModel.password);
				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(registerViewModel);
		}
    }
}
