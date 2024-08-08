using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public string? Description { get; set; }

    public int CateId { get; set; }

    public int? Quantity { get; set; }

    public virtual Category Cate { get; set; } = null!;

    public virtual ICollection<ImageVideo> ImageVideos { get; set; } = new List<ImageVideo>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
