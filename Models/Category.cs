using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Category
{
    public int Cid { get; set; }

    public string? Cname { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
