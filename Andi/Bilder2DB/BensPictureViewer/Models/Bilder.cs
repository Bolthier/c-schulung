using System;
using System.Collections.Generic;

namespace BensPictureViewer.Models;

public partial class Bilder
{
    public string VollerName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Typ { get; set; } = null!;

    public DateTime Datum { get; set; }

    public int Groesse { get; set; }

    public byte[] Daten { get; set; } = null!;
}
