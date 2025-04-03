using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebCompanyNew.Models;

namespace WebCompanyNew.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		DBMethods methods = new DBMethods();

		public IActionResult Index()
		{
			List<Personal> personal = methods.GetPersonals();
			List<Event> events = methods.GetEvents();
			List<News> news = methods.GetNews();
			ViewBag.Events = events;
			ViewBag.News = news;
			return View(personal);
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
}
