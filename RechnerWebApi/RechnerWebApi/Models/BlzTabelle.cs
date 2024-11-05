using System;
using System.Collections.Generic;

namespace RechnerWebApi.Models;

public partial class BlzTabelle
{
    public Guid Id { get; set; }

    public string? Blz { get; set; }

    public string? Name { get; set; }

    public string? Plz { get; set; }

    public string? Ort { get; set; }
}
