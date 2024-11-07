using System;
using System.Collections.Generic;

namespace MyMudBlazor.Models;

public partial class UmsatzByGruppe
{
    public int? CategoryId { get; set; }

    public string? Country { get; set; }

    public int? Anzahl { get; set; }

    public decimal? Umsatz { get; set; }
}
