using System;
using System.Collections.Generic;

namespace Modelo;

public partial class Producto
{
    public int IdProd { get; set; }

    public string? NombreProd { get; set; }

    public int? IdCate { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Costo { get; set; }

    public string? Descripcion { get; set; }

    public int? Activo { get; set; }

    public DateTime? FechaIntro { get; set; }

    public virtual ICollection<DetaOrden> DetaOrdens { get; set; } = new List<DetaOrden>();

    public virtual Categorium? IdCategoriaNavigation { get; set; }
}
