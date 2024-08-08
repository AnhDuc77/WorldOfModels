using System;
using System.Collections.Generic;

namespace WorldOfModeWeb.Models;

public partial class Message
{
    public int Id { get; set; }

    public int? Sender { get; set; }

    public int? Receiver { get; set; }

    public string? Message1 { get; set; }

    public string? MessageType { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Account? ReceiverNavigation { get; set; }

    public virtual Account? SenderNavigation { get; set; }
}
