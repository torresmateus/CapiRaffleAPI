using System;
using System.Collections.Generic;

namespace CapiRaffle.MODEL;

public partial class Rifa
{
    public int Id { get; set; }

    public string NomeCriador { get; set; } = null!;

    public string CpfCriador { get; set; } = null!;

    public string PixCriador { get; set; } = null!;

    public string NomeRifa { get; set; } = null!;

    public string PremioRifa { get; set; } = null!;

    public string ValorRifa { get; set; } = null!;

    public DateTime DataTermino { get; set; }

    public virtual ICollection<Comprador> Compradors { get; set; } = new List<Comprador>();
}
