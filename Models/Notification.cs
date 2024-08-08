using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public string? NotificationMessage { get; set; }

    public DateTime? NotificationDateTime { get; set; }

    public int? ReceiverId { get; set; }

    public int? SenderId { get; set; }

    public bool? ConfirmationStatus { get; set; }

    public string? TypeOfNotification { get; set; }

    public virtual Account? Receiver { get; set; }

    public virtual Account? Sender { get; set; }
}
