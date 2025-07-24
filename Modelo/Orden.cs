using System;
using System.Collections.Generic;

namespace Modelo;

public partial class Orden
{
    public int IdOrden { get; set; }

    public int? IdCliente { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? CantiTotal { get; set; }

    public int? IdEstado { get; set; }

    public decimal? Taxes { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetaOrden> DetaOrdens { get; set; } = new List<DetaOrden>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual EstadoO? IdEstadoNavigation { get; set; }
}
