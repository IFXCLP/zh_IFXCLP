using System;
using System.Collections.Generic;

namespace zh_IFXCLP.Models;

public partial class Posztok
{
    public int PosztId { get; set; }

    public string Poszt { get; set; } = null!;

    public virtual ICollection<Jatekosok> Jatekosoks { get; } = new List<Jatekosok>();
}
