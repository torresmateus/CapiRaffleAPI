using System;
using System.Collections.Generic;

namespace CapiRaffle.MODEL;

public partial class Comprador
{
    public int Id { get; set; }

    public string NomeComprador { get; set; } = null!;

    public string CpfComprador { get; set; } = null!;

    public string Numeros { get; set; } = null!;

    public int IdRifa { get; set; }

    public virtual Rifa IdRifaNavigation { get; set; } = null!;
}
