using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class UserInfor
{
    public int AccountId { get; set; }

    public string? Name { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Ward { get; set; }

    public string? AddressDetail { get; set; }

    public string? Gender { get; set; }

    public string? Avatar { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Account Account { get; set; } = null!;
}
