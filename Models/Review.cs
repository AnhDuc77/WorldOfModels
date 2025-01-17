﻿using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? ProductId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public int? Star { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Account? User { get; set; }
}
