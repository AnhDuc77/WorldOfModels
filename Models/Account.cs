using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? Role { get; set; }

    public string? Email { get; set; }

    public int TypeLogin { get; set; }

    public virtual ICollection<Message> MessageReceiverNavigations { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageSenderNavigations { get; set; } = new List<Message>();

    public virtual ICollection<Notification> NotificationReceivers { get; set; } = new List<Notification>();

    public virtual ICollection<Notification> NotificationSenders { get; set; } = new List<Notification>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual UserInfor? UserInfor { get; set; }
}
