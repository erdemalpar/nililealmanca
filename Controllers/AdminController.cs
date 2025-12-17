using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GermanLearningApp.Mvc.Services;
using GermanLearningApp.Mvc.Models;

namespace GermanLearningApp.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly LearningDataService _dataService;
        private readonly UserService _userService;
        private readonly LogService _logService;

        public AdminController(LearningDataService dataService, UserService userService, LogService logService)
        {
            _dataService = dataService;
            _userService = userService;
            _logService = logService;
        }

        public IActionResult Index()
        {
            var lessonCount = _dataService.GetLessons().Count;
            ViewBag.TotalLessons = lessonCount;
            ViewBag.StudentCount = _userService.GetAllStudents().Count;
            return View();
        }

        public IActionResult Logs()
        {
            var logs = _logService.GetLogs();
            return View(logs);
        }

        [HttpGet]
        public IActionResult GetStudentsPartial()
        {
            var students = _userService.GetAllStudents();
            return PartialView("_StudentListPartial", students);
        }

        [HttpGet]
        public IActionResult GetStudentPermissionsPartial(string username)
        {
            var user = _userService.GetUser(username);
            if (user == null) return NotFound();

            // Pass all available lessons for selection
            ViewBag.AllLessons = _dataService.GetLessons();
            return PartialView("_StudentPermissionsPartial", user);
        }

        [HttpPost]
        public IActionResult UpdatePermissions([FromBody] UpdatePermissionsModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Username))
            {
                return BadRequest("Geçersiz veri.");
            }

            _userService.UpdatePermissions(model.Username, model.AllowedPages);
            _logService.Log("UpdatePermissions", User.Identity.Name, $"{model.Username} kullanıcısının izinleri güncellendi.");
            
            return Json(new { success = true });
        }
    }

    public class UpdatePermissionsModel
    {
        public string Username { get; set; }
        public List<string> AllowedPages { get; set; }
    }
}
