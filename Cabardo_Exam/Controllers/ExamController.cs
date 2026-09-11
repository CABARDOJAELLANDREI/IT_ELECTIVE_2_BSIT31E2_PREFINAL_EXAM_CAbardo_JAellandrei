using Microsoft.AspNetCore.Mvc;
using ExamApp.Models; // Change 'ExamApp' to match your project namespace

namespace ExamApp.Controllers
{
    public class ExamController : Controller
    {
        private static readonly List<ExamQuestion> Questions = new List<ExamQuestion>
        {
            // Question 1
            new ExamQuestion
            {
                Id = 1,
                QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                Options = new List<string>
                {
                    "A. It makes C# code shorter",
                    "B. It prevents the application from restarting",
                    "C. It allows data to persist after the application stops",
                    "D. It removes the need for MVC"
                },
                CorrectAnswer = "C. It allows data to persist after the application stops",
                Explanation = "Databases persist data to disk, whereas in-memory data is cleared when the application stops."
            }
        };

        public IActionResult Index()
        {
            return View(Questions);
        }
    }
}