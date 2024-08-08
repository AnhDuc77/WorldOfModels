using Microsoft.AspNetCore.Mvc;

namespace WorldOfModeWeb.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
