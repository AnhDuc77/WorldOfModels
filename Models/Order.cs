using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime? OrderDateTime { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public double? TotalMoney { get; set; }

    public int? Payment { get; set; }

    public int? Status { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Ward { get; set; }

    public string? AddressDetail { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Account? User { get; set; }
}
