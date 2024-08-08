using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class ImageVideo
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public byte Type { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
