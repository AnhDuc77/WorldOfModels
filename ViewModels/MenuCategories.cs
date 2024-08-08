using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WorldOfModeWeb.ViewModels
{
	public class MenuCategories
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int Quantity { get; set; }
	}
}
