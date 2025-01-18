using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services; // This is added because we need to use the page counter service.

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageCounterService _pageCounterService; // This is added to store the page counter service.

        // Constructor with Dependency Injection
        public HomeController(IPageCounterService pageCounterService)
        {
            _pageCounterService = pageCounterService; // This is added to initialize the page counter service.
        }

        // Index Action
        public IActionResult Index()
        {
            int count = _pageCounterService.IncrementPageCount("Home"); // This will increase the count for the "Home" page.
            return View(count); // This is added to pass the count to the view.
        }

        // OtherPage Action
        public IActionResult OtherPage()
        {
            int count = _pageCounterService.IncrementPageCount("OtherPage"); // This will increase the count for the "OtherPage."
            return View(count); // This is added to pass the count to the view.
        }
    }
}
