using System;
using System.Collections.Generic;

namespace zh_IFXCLP.Models;

public partial class Jatekosok
{
    public int Id { get; set; }

    public int NemzetisegId { get; set; }

    public int PosztId { get; set; }

    public int Sarga { get; set; }

    public virtual Nemzetisegek Nemzetiseg { get; set; } = null!;

    public virtual Posztok Poszt { get; set; } = null!;
}
