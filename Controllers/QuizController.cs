using Microsoft.AspNetCore.Mvc;
using BSIT_32E1_Elective_2_Assignment_1.Models;

namespace BSIT_32E1_Elective_2_Assignment_1.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Id = 1,
                    Question = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Choices = new[]
                    {
                        "A) SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                        "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                        "C) SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                        "D) SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly."
                    },
                    CorrectAnswer = "B"
                },
                new QuizQuestion
                {
                    Id = 2,
                    Question = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    Choices = new[]
                    {
                        "A) ControllerBase supports Razor View rendering using View() and ViewData.",
                        "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead.",
                        "C) Controller is obsolete in .NET 8 and cannot handle HTTP POST requests.",
                        "D) ControllerBase automatically creates SQLite database files on application startup."
                    },
                    CorrectAnswer = "B"
                },
                new QuizQuestion
                {
                    Id = 3,
                    Question = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Choices = new[]
                    {
                        "A) [Route]",
                        "B) [HttpGet]",
                        "C) [ApiController]",
                        "D) [FromQuery]"
                    },
                    CorrectAnswer = "C"
                },
                new QuizQuestion
                {
                    Id = 4,
                    Question = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Choices = new[]
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 404 Not Found"
                    },
                    CorrectAnswer = "B"
                },
                new QuizQuestion
                {
                    Id = 5,
                    Question = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Choices = new[]
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 400 Bad Request"
                    },
                    CorrectAnswer = "C"
                },
                new QuizQuestion
                {
                    Id = 6,
                    Question = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                    Choices = new[]
                    {
                        "A) GET /api/getAllCourses",
                        "B) GET /api/courses",
                        "C) POST /api/createNewCourseRecord",
                        "D) POST /api/deleteCourseById?id=5"
                    },
                    CorrectAnswer = "B"
                },
                new QuizQuestion
                {
                    Id = 7,
                    Question = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Choices = new[]
                    {
                        "A) It connects the controller directly to an Entity Framework database context.",
                        "B) It maps incoming URI request paths to the controller class using the class name token.",
                        "C) It encrypts all incoming JSON payloads.",
                        "D) It enables Cross-Origin Resource Sharing (CORS) for external React apps."
                    },
                    CorrectAnswer = "B"
                },
                new QuizQuestion
                {
                    Id = 8,
                    Question = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Choices = new[]
                    {
                        "A) POST",
                        "B) PUT",
                        "C) GET",
                        "D) DELETE"
                    },
                    CorrectAnswer = "C"
                }
            };

            return View(questions);
        }
    }
}