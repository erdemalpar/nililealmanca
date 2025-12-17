using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using GermanLearningApp.Mvc.Models;
using GermanLearningApp.Mvc.Services;

namespace GermanLearningApp.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _userService;
        private readonly LogService _logService;

        public AccountController(UserService userService, LogService logService)
        {
            _userService = userService;
            _logService = logService;
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.ValidateUser(model.Username, model.Password);

                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Role, user.Role)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, "CookieAuth");
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = true // Keep logged in
                    };

                    await HttpContext.SignInAsync("CookieAuth", new ClaimsPrincipal(claimsIdentity), authProperties);
                    _logService.Log("Login", user.Username, "Başarılı giriş");

                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    
                    // Redirect based on role
                    if (user.Role == "Admin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }

                    return RedirectToAction("Index", "Home");
                }

                _logService.Log("LoginFailed", model.Username ?? "Unknown", "Hatalı şifre veya kullanıcı adı");
                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            var username = User.Identity?.Name ?? "Unknown";
            await HttpContext.SignOutAsync("CookieAuth");
            _logService.Log("Logout", username, "Çıkış yapıldı");
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool success = _userService.RegisterUser(model.Username, model.Password, model.Class);
                if (success)
                {
                    _logService.Log("Register", model.Username, $"Yeni kayıt: {model.Class}");
                    TempData["SuccessMessage"] = "Kayıt başarılı! Lütfen giriş yapın.";
                    return RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError("Username", "Bu kullanıcı adı zaten alınmış.");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
