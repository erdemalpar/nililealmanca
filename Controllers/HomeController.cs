using System;
using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GermanLearningApp.Mvc.Models;
using GermanLearningApp.Mvc.Services;

namespace GermanLearningApp.Mvc.Controllers;

[Microsoft.AspNetCore.Authorization.Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly LearningDataService _dataService;
    private readonly UserService _userService; // Inject UserService

    public HomeController(ILogger<HomeController> logger, LearningDataService dataService, UserService userService)
    {
        _logger = logger;
        _dataService = dataService;
        _userService = userService;
    }

    public IActionResult Index()
    {
        var model = new DashboardViewModel
        {
            Vocabulary = _dataService.GetVocabulary().Take(5).ToList(), // Show first 5 for dashboard
            Score = new ScoreModel { Points = 0, TotalQuestions = 0 } // Initial score
        };
        return View(model);
    }
    
    [HttpGet]
    public IActionResult Lessons(int? activeLessonId)
    {
        int lessonId = activeLessonId ?? 1;
        var lessons = _dataService.GetLessons();

        // Randomize quiz options (Fisher-Yates shuffle approximation via OrderBy+Random)
        // This ensures the correct answer (usually the first one in data) isn't always option A.
        var rnd = new Random();
        foreach (var lesson in lessons)
        {
            if (lesson.Quiz != null)
            {
                foreach (var q in lesson.Quiz)
                {
                    if (q.Options != null && q.Options.Count > 1)
                    {
                        q.Options = q.Options.OrderBy(x => rnd.Next()).ToList();
                    }
                }
            }
        }
        var permittedLessonIds = new List<int>();

        // Authorization Check & Permission Data Construction
        if (User.IsInRole("Admin"))
        {
            // Admin sees all
            permittedLessonIds = lessons.Select(l => l.Id).ToList();
        }
        else if (User.IsInRole("User"))
        {
            var user = _userService.GetUser(User.Identity.Name);
            if (user != null)
            {
                // Check current specific lesson permission for access control
                string requiredPermission = $"/lesson/details/{lessonId}";
                if (user.AllowedPages == null || !user.AllowedPages.Contains(requiredPermission.ToLower()))
                {
                   return RedirectToAction("AccessDenied", "Account");
                }

                // Calculate all permitted IDs for UI logic
                // Iterate all lessons and check if user has permission string
                foreach(var l in lessons)
                {
                    string permString = $"/lesson/details/{l.Id}".ToLower();
                    if (user.AllowedPages != null && user.AllowedPages.Contains(permString))
                    {
                        permittedLessonIds.Add(l.Id);
                    }
                }
            }
        }
        
        ViewBag.ActiveLessonId = lessonId;
        ViewBag.PermittedLessonIds = permittedLessonIds; // Pass to View
        return View(lessons);
    }

    public IActionResult Quiz()
    {
        // Authorization Check
        if (User.IsInRole("User"))
        {
            var user = _userService.GetUser(User.Identity.Name);
            if (user != null)
            {
                string requiredPermission = "/quiz/generalquiz";
                if (user.AllowedPages == null || !user.AllowedPages.Contains(requiredPermission.ToLower()))
                {
                   return RedirectToAction("AccessDenied", "Account");
                }
            }
        }
        
        var questions = _dataService.GetGeneralQuizQuestions();
        return View(questions);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

// Simple ViewModel for Dashboard
public class DashboardViewModel
{
    public List<VocabularyWord> Vocabulary { get; set; }
    public ScoreModel Score { get; set; }
}

public class ScoreModel
{
    public int Points { get; set; }
    public int TotalQuestions { get; set; }
}
