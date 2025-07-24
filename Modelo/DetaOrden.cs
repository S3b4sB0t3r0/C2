using System;
using System.Collections.Generic;

namespace Modelo;

public partial class DetaOrden
{
    public int IdDeta { get; set; }

    public int? IdOr { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public int? IdProd { get; set; }

    public virtual Orden? IdOrNavigation { get; set; }

    public virtual Producto? IdProdNavigation { get; set; }
}
