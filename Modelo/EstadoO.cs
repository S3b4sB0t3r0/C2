using System;
using System.Collections.Generic;

namespace Modelo;

public partial class EstadoO
{
    public int IdEstadoO { get; set; }

    public string? NombreEsO { get; set; }

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
}
