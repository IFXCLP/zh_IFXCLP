using System;
using System.Collections.Generic;

namespace zh_IFXCLP.Models;

public partial class Nemzetisegek
{
    public int NemzetisegId { get; set; }

    public string? Nemzetiseg { get; set; }

    public virtual ICollection<Jatekosok> Jatekosoks { get; } = new List<Jatekosok>();
}
