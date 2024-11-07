using System;
using System.Collections.Generic;

namespace MyMudBlazor.Models;

public partial class KundenByProductId
{
    public string CompanyName { get; set; } = null!;

    public string? Country { get; set; }

    public string? City { get; set; }

    public int ProductId { get; set; }
}
