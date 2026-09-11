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
            },

            // Question 2
            new ExamQuestion
            {
                Id = 2,
                QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Options = new List<string>
                {
                    "A. Code-First",
                    "B. Database-First",
                    "C. Model-First",
                    "D. Controller-First"
                },
                CorrectAnswer = "B. Database-First",
                Explanation = "Database-First reverse-engineers entity models and DbContext from an existing database schema."
            },

            // Question 3
            new ExamQuestion
            {
                Id = 3,
                QuestionText = "What is the primary purpose of Entity Framework Core?",
                Options = new List<string>
                {
                    "A. To create HTML pages automatically",
                    "B. To replace the MVC Controller",
                    "C. To map objects in code to relational database data",
                    "D. To replace the C# compiler"
                },
                CorrectAnswer = "C. To map objects in code to relational database data",
                Explanation = "EF Core is an Object-Relational Mapper (ORM) that bridges C# objects and relational database tables."
            },

            // Question 4
            new ExamQuestion
            {
                Id = 4,
                QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                Options = new List<string>
                {
                    "A. DbContext",
                    "B. DbSetView",
                    "C. ControllerContext",
                    "D. RazorContext"
                },
                CorrectAnswer = "A. DbContext",
                Explanation = "DbContext manages database connections, session tracking, and query executions."
            },

            // Question 5
            new ExamQuestion
            {
                Id = 5,
                QuestionText = "What does the command 'dotnet ef dbcontext scaffold' primarily do?",
                Options = new List<string>
                {
                    "A. Deletes the database",
                    "B. Creates a new MVC project",
                    "C. Generates EF Core models and a DbContext from an existing database",
                    "D. Starts the MVC application"
                },
                CorrectAnswer = "C. Generates EF Core models and a DbContext from an existing database",
                Explanation = "Scaffolding generates C# entity classes and a DbContext instance directly from an existing database schema."
            },

            // Question 6
            new ExamQuestion
            {
                Id = 6,
                QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Options = new List<string>
                {
                    "A. Program.cs only",
                    "B. appsettings.json",
                    "C. Index.cshtml",
                    "D. Student.cs"
                },
                CorrectAnswer = "B. appsettings.json",
                Explanation = "Application configuration settings, including connection strings, belong in appsettings.json."
            },
        };

        public IActionResult Index()
        {
            return View(Questions);
        }
    }
}