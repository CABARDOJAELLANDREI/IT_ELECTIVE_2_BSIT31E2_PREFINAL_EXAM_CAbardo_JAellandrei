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

            // Question 7
            new ExamQuestion
            {
                Id = 7,
                QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Options = new List<string>
                {
                    "A. One-to-One",
                    "B. One-to-Many",
                    "C. Many-to-Many",
                    "D. Many-to-One only"
                },
                CorrectAnswer = "B. One-to-Many",
                Explanation = "A single Section entity maps to multiple Student entities."
            },

            // Question 8
            new ExamQuestion
            {
                Id = 8,
                QuestionText = "In the following example, what is SectionId? 'public int SectionId { get; set; } public Section Section { get; set; }'",
                Options = new List<string>
                {
                    "A. Primary key of Student",
                    "B. Foreign key referencing Section",
                    "C. Navigation property",
                    "D. Database connection string"
                },
                CorrectAnswer = "B. Foreign key referencing Section",
                Explanation = "SectionId holds the foreign key value that references the primary key of the Section table."
            },

            // Question 9
            new ExamQuestion
            {
                Id = 9,
                QuestionText = "What is the purpose of a navigation property such as 'public Section Section { get; set; }'?",
                Options = new List<string>
                {
                    "A. It stores the database password",
                    "B. It represents a relationship to another entity",
                    "C. It creates a new database",
                    "D. It validates the student's name"
                },
                CorrectAnswer = "B. It represents a relationship to another entity",
                Explanation = "Navigation properties enable navigating relationships between related entity objects in code."
            },

            // Question 10
            new ExamQuestion
            {
                Id = 10,
                QuestionText = "What does .Include() generally allow EF Core to do?",
                Options = new List<string>
                {
                    "A. Delete the Section table",
                    "B. Load related Section data together with Students",
                    "C. Create a new Student",
                    "D. Validate Student input"
                },
                CorrectAnswer = "B. Load related Section data together with Students",
                Explanation = "The .Include() method performs eager loading to fetch related entity data alongside the main query."
            },

            // Question 11
            new ExamQuestion
            {
                Id = 11,
                QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                Options = new List<string>
                {
                    "A. To replace the database",
                    "B. To combine or shape the data specifically needed by the view",
                    "C. To automatically create database tables",
                    "D. To prevent controllers from using LINQ"
                },
                CorrectAnswer = "B. To combine or shape the data specifically needed by the view",
                Explanation = "ViewModels serve as custom data wrappers tailored specifically for UI rendering needs."
            },

            // Question 12
            new ExamQuestion
            {
                Id = 12,
                QuestionText = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",
                Options = new List<string>
                {
                    "A. It loads the related Section navigation property",
                    "B. It creates a Section object manually",
                    "C. It removes the foreign key",
                    "D. It prevents the query from accessing the database"
                },
                CorrectAnswer = "A. It loads the related Section navigation property",
                Explanation = "Passing the expression 's => s.Section' to Include ensures the related Section model is populated."
            },

            // Question 13
            new ExamQuestion
            {
                Id = 13,
                QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                Options = new List<string>
                {
                    "A. Database-level validation",
                    "B. Client-side validation",
                    "C. Server-side validation",
                    "D. EF Core migration validation"
                },
                CorrectAnswer = "B. Client-side validation",
                Explanation = "Client-side validation runs in the browser via JavaScript to check user input before submission."
            },

            // Question 14
            new ExamQuestion
            {
                Id = 14,
                QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                Options = new List<string>
                {
                    "A. Client-side validation can be bypassed",
                    "B. Client-side validation automatically modifies the database",
                    "C. Server-side validation only works with SQLite",
                    "D. Client-side validation cannot display messages"
                },
                CorrectAnswer = "A. Client-side validation can be bypassed",
                Explanation = "Client-side validation can be disabled or bypassed, making server-side checks crucial for security."
            },
        };

        public IActionResult Index()
        {
            return View(Questions);
        }
    }
}