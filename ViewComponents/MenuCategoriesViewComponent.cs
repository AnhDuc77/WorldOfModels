using Microsoft.AspNetCore.Mvc;
using WorldOfModeWeb.Models;
using WorldOfModeWeb.ViewModels;
namespace WorldOfModeWeb.ViewComponents
{
	public class MenuCategoriesViewComponent : ViewComponent
	{
		private readonly WorldOfModelContext _worldOfModelContext;
		public MenuCategoriesViewComponent(WorldOfModelContext context) => _worldOfModelContext = context;
		public IViewComponentResult Invoke()
		{
			var data = _worldOfModelContext.Categories.Select(ca => new MenuCategories
			{
				Id = ca.Cid,
				Name = ca.Cname,
				Quantity = ca.Products.Count,
			}
			);
			return View(data);
		}
	}
}
