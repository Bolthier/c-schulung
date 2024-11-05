using System;
using System.Collections.Generic;

namespace De.Wortmann.Chat.Db.Models;

public partial class Chat
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public string Header { get; set; } = null!;

    public string Datecreate { get; set; } = null!;

    public string Sender { get; set; } = null!;
}
